using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

/**********************************************************/
// Filename:  Form1.cs
// Purpose:   This program tracks my friends birthdays and tells me what they like and dislike as a gift
// Author:    Ivon Harris
// Version:   1.7
// Date:	  27/02/2022
// Tests:	  Test Run on Validate data method
              
/**********************************************************/


namespace BirthdayTracker
{
    public partial class Form1 : Form
    {
        // friendlist stored in external file MyFriendData.csv
        // friend list of friend data
        private List<Friends> friendList;
        // current selected record
        private int currentRecord;
        // file path
        string filePath = @"MyFriendData.csv";
        // string array (Biirthday month button)
        private int month;

        
        static public string[] birthMonthIs = {"ALL", "Jan - 1 ","Feb - 2 ", "Mar - 3 ", "Apr - 4 ", "May - 5 ", "Jun - 6", "Jul - 7 ", "Aug - 8 ", "Sep - 9 ",
                                    "Oct - 10 ", "Nov - 11 ", "Dec - 12 "};
        // Form1() constructor method
        public Form1()
        {
            InitializeComponent();

            // instantiate the friendList
            friendList = new List<Friends>();
            //read external file data and set up friendList
            ReadFriendData();
            //display friend data in friendsTextbox
            DisplayFriendData();
            // set the current Record to 0;
            currentRecord = 0;
            // Display current Records
            DisplayCurrentRecord();

        }

        public void ReadFriendData()
        {
            // read external file
            try
            {
                if (File.Exists(filePath))
                {
                    // Read file using StreamReader
                    // Reads file line by line
                    using (StreamReader file = new StreamReader(filePath))
                    {
                        string line;
                        int lineCount = 0;

                        while ((line = file.ReadLine()) != null)
                        {
                            lineCount++;
                            if (lineCount == 0)
                            {
                                continue;
                            }
                            //split the line into a string array
                            string[] lineArray = line.Split(',');
                            // assign array values to string vars
                            string name = lineArray[0];
                            string likes = lineArray[1];
                            string dislikes = lineArray[2];
                            int day = Int32.Parse(lineArray[3]);
                            int month = Int32.Parse(lineArray[4]);
                            // create Friends instance
                            Friends friends = new Friends(name, likes, dislikes, day, month);
                            // add instance to friendList
                            friendList.Add(friends);
                        }// end while loop
                        file.Close();
                    }// end stream reader
                }//end if
                else
                {
                    Console.WriteLine("ERROR: No external file exists for: " + filePath);
                }
            } // end try block
            catch (IOException ioe)
            {
                Console.WriteLine("ERROR: Problem in reading the external file: " + filePath);
                Console.WriteLine(ioe.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: Problem with external file: " + filePath);
                Console.WriteLine(e.Message);
            }
        }// end ReadFriendData();

        public void DisplayFriendData()
        {
            String displayText = "Name\t Likes\t Dislikes\t Day\t Month\n";
            displayText += "--------------------------------------------------------\r\n";
            for (int i = 0; i < friendList.Count(); i++)

            {
                displayText += friendList[i].ToString() + "\r\n";
            }
            //MessageBox.Show(displayText);
            listTextBox.Text = displayText;

        }

        public void DisplayFriendByMonth(int Month)
        {
            String displayText = "Name\t Likes\t Dislikes\t Day\t Month\n";
            displayText += "--------------------------------------------------------\r\n";
            for (int i = 0; i < friendList.Count(); i++)
            // read in the friend list birthday month
            {
                if (friendList[i].Month == Month)
                {
                    displayText += friendList[i].ToString() + "\r\n";
                }
                else if (Month == 0)
                {
                    displayText += friendList[i].ToString() + "\r\n";
                }
                
            }
            listTextBox.Text = displayText;
            calendarTextBox.Text = birthMonthIs[Month].ToString();
        }


        //create current record
        public void DisplayCurrentRecord()
        {
            personTextBox.Text = friendList[currentRecord].Name;
            likesTextBox.Text = friendList[currentRecord].Likes;
            dislikeTextBox.Text = friendList[currentRecord].Dislikes;
            birthdayTextBox.Text = friendList[currentRecord].Day.ToString();
            birthMonthTextBox.Text = friendList[currentRecord].Month.ToString();
        }//end DisplayCurrentRecord()

        private void findButton_Click(object sender, EventArgs e)
        {
            // check if the search text box is not empty
            if (String.IsNullOrEmpty(findTextbox.Text))
            {
                MessageBox.Show("You need to put a name in here", "ERROR!");
                return;
            }
            else
            {
                // look fir the name of your friend in friendList
                // string of the search item (Name)
                string recordToSearch = findTextbox.Text;
                // boolean for foundStatus
                bool foundStatus = false;
                // linear search through the list
                for (int i = 0; i < friendList.Count; i++)
                {
                    //check if last name exists in the list
                    if (recordToSearch.Equals(friendList[i].Name))
                    {
                        // if found, change currentRecord to the index
                        currentRecord = i;
                        //display the found record
                        DisplayCurrentRecord();
                        //inform the user the record was found
                        MessageBox.Show(recordToSearch + "YOU HAVE A FRIEND!");
                        // change the foundstatus to true
                        foundStatus = true;
                        // break the loop
                        break;
                    }// end of record search
                } // end of for loop
                // check if not found
                if (!foundStatus)
                {
                    // inform user that the record was not found
                    MessageBox.Show(recordToSearch + "  is not a friend yet maybe add them", "Better luck next time, go get some friends");
                }
            }
        }// end of button event handler

        // Validation of data converts int text
        public bool ValidateData()
        {
            bool checkBox = true;
            string errorMessage = "ERROR(S) Encountered\n";
            int birthdayDay;
            int birthdayMonth;

            //string errorMessage = "ERROR(S) Encountered\n";
            // check friend textbox
            if (String.IsNullOrEmpty(personTextBox.Text))
            {
                errorMessage += "Friend name is required\n";
                checkBox = false;
            }
            // check last name text box
            if (String.IsNullOrEmpty(likesTextBox.Text))
            {
                errorMessage += "Likes is required\n";
                checkBox = false;
            }
            //check dislikes text box
            if (String.IsNullOrEmpty(dislikeTextBox.Text))
            {
                errorMessage += "dislikes is required\n";
                checkBox = false;
            }
            //check day of birth day text box
            if (String.IsNullOrEmpty(birthdayTextBox.Text))
            {
                errorMessage += "must have a birth 'day' \n";
                checkBox = false;
            }
            //check birth month text box
            if (String.IsNullOrEmpty(birthMonthTextBox.Text))
            {
                errorMessage += "must have a birth 'month'\n";
                checkBox = false;
            }
            if (checkBox == true) {
                birthdayDay = Int32.Parse(birthdayTextBox.Text);
                birthdayMonth = Int32.Parse(birthMonthTextBox.Text);
                switch (birthdayMonth)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        if (birthdayDay < 1 || birthdayDay > 31)
                        {
                            errorMessage += "Check month error, only 1 - 31 days in these months \n";
                            checkBox = false;
                        }
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        if (birthdayDay < 1 || birthdayDay > 30)
                        {
                            errorMessage += "Check month error, only 1 - 30 days in these months \n";
                            checkBox = false;
                        }
                        break;
                    case 2:
                        if (birthdayDay < 1 || birthdayDay > 29)
                        {
                            errorMessage += "Check month error, only 1 - 29 days in this months \n";
                            checkBox = false;
                        }
                        break;

                }// end switch
            }
            
            if (checkBox == false)
            {
                MessageBox.Show(errorMessage, "Errors!");
            }
            return checkBox;
        }


        // add new record method
        private void AddNewRecord()
        {
            if (ValidateData() == false)
            {
                return;
            }
            else
            {
                // prompt the user to proceed with the save
                DialogResult dialogResult = MessageBox.Show("Do you wish to update this existing Friend?", "UPDATE FRIEND", MessageBoxButtons.YesNo);
                // if Yes button clicked, then proceed
                if (dialogResult == DialogResult.Yes)
                {
                    //proceed
                    // get all 9 values for the new enrolment
                    string name = personTextBox.Text;
                    string likes = likesTextBox.Text;
                    string dislikes = dislikeTextBox.Text;
                    int day = Int32.Parse(birthdayTextBox.Text.Trim());
                    int month = Int32.Parse(birthMonthTextBox.Text.Trim());

                    // create new enrolment object
                    Friends newFriend = new Friends(name, likes, dislikes, day, month);
                    // add to the enrolmentsList
                    friendList[currentRecord] = newFriend;
                    // append new enrolment to external CSV file
                    // CSV string version of newEnrolment object
                    string newFriendCSV = newFriend.ToCSVString();
                    // append CSV string to external CSV file
                    using (StreamWriter file = File.AppendText(@"MyFriendData.csv"))
                    {
                        file.WriteLine(newFriendCSV);
                    }
                    // re-sort the enrolmentList
                    friendList.Sort();
                    // display newly sorted enrolment list
                    DisplayFriendData();
                    // get the index number of the new enrolment
                    // and assign to currentRecord
                    currentRecord = friendList.IndexOf(newFriend);


                }
            }
        }

        // birthday text box only accepts an integer between 1 - 9
        private void birthdayTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(birthdayTextBox.Text, "  ^ [0-9]"))
            {
                birthdayTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Must be a number only");
            }
        }

        // birthmonth text box only accepts an integer between 1 - 9
        private void birthmonthTextBox_TextChanged(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(birthMonthTextBox.Text, "  ^ [0-9]"))
            {
                birthMonthTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Must be a number only");
            }
        }
        private void frontButton_Click(object sender, EventArgs e)
        {
            // go to first record in list index of 0
            currentRecord--;
            // no checking of record as the index should be [0]
            currentRecord = 0;
            DisplayCurrentRecord();
        }// end front button

        private void prevButton_Click(object sender, EventArgs e)
        {
            // go to the previous record in the enrolmentList
            currentRecord--;
            // check if currentRecord not less than zero
            // if so, then assign to last element index
            // (or Count – 1) of the enrolmentList
            // this being the last record
            if (currentRecord < 0)
            {
                currentRecord = friendList.Count - 1;
            }
            // display this record in the enrolments listing
            DisplayCurrentRecord();
        }// end previous button

        private void nextButton_Click(object sender, EventArgs e)
        {
            // go to the next record in the friendlist
            currentRecord++;
            // check if currentRecord not greater than the list length - 1
            // if so, then assign to first element index [0]
            // of the enrolmentList
            // this being the first record
            if (currentRecord == friendList.Count)
            {
                currentRecord = 0;
            }
            // display this record in the friendlist listing
            DisplayCurrentRecord();
        }// end next button

        private void backButton_Click(object sender, EventArgs e)
        {
            // go to the next record in the friendlist
            currentRecord = friendList.Count - 1;
            DisplayCurrentRecord();
        }// end back button

        private void exitButton_Click(object sender, EventArgs e)
        {

            if (ValidateData() == false)
            {
                return;
            }
            else
            {
                // prompt the user to proceed with the save
                DialogResult dialogResult = MessageBox.Show("You are about to exit, click yes to save your data", "EXIT APPLICATION", MessageBoxButtons.YesNo);
                // if Yes button clicked, then proceed
                if (dialogResult == DialogResult.Yes)
                {
                    //proceed
                    // get all values for save
                    string name = personTextBox.Text;
                    string likes = likesTextBox.Text;
                    string dislikes = dislikeTextBox.Text;
                    int day = Int32.Parse(birthdayTextBox.Text);
                    int month = Int32.Parse(birthMonthTextBox.Text);
                    // create new friend object
                    Friends newFriend = new Friends(name, likes, dislikes, day, month);
                    // add to the friendList
                    friendList[currentRecord] = newFriend;
                    // append new enrolment to external CSV file
                    // CSV string version of Friend object
                    friendList.Sort();
                    //proceed to update data
                    friendListupdate();
                    MessageBox.Show("Saved Goodbye");
                    Application.Exit();
                }
                else if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }// end exit button

        // method to write lines in csv (update)
        public void friendListupdate()
        {
            // make a string for csv
            List<string> writeLines = new List<string>();
            string strLine;
            for (int i = 0; i < friendList.Count; i++)
            {
                // to string method 
                Friends newFriendInfo = new Friends(friendList[i].Name, friendList[i].Likes, friendList[i].Dislikes, friendList[i].Day, friendList[i].Month);
                strLine = newFriendInfo.ToCSVString();
                writeLines.Add(strLine);
            }

            using (StreamWriter WriteFile = new StreamWriter(filePath, false))
            {
                // write to csv
                foreach (string csvLine in writeLines)
                {
                    WriteFile.WriteLine(csvLine);
                }
            }

        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            AddNewRecord();
        }// end update_button_click() event handler method


        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (ValidateData() == false)
            {
                MessageBox.Show("Error " + e);
                return;
            }
            else
            {
                // prompt the user to proceed with the save
                DialogResult dialogResult = MessageBox.Show("Do you wish to add this new friend?", "NEW FRIEND RECORD", MessageBoxButtons.YesNo);
                // if Yes button clicked, then proceed
                if (dialogResult == DialogResult.Yes)
                {
                    //proceed
                    // get all 9 values for the new enrolment
                    string name = personTextBox.Text;
                    string likes = likesTextBox.Text;
                    string dob = dislikeTextBox.Text;
                    int day = Int32.Parse(birthdayTextBox.Text);
                    int month = Int32.Parse(birthMonthTextBox.Text);
                    // create new enrolment object
                    Friends Friend = new Friends(name, likes, dob, day, month);
                    // add to the enrolmentsList
                    friendList.Add(Friend);
                    // append new enrolment to external CSV file
                    // CSV string version of newEnrolment object
                    string newEnrolmentCSV = Friend.ToCSVString();
                    // append CSV string to external CSV file
                    using (StreamWriter file = File.AppendText(@"enrolments.csv"))
                    {
                        file.WriteLine(newEnrolmentCSV);
                    }
                    // re-sort the enrolmentList
                    friendList.Sort();
                    // display newly sorted enrolment list
                    currentRecord = friendList.IndexOf(Friend);
                    // get the index number of the new enrolment
                    // and assign to currentRecord
                    DisplayCurrentRecord();
                    // re-sort the enrolmentList
                    friendList.Sort();
                    // display newly sorted enrolment list
                    DisplayFriendData();
                    // and assign to currentRecord
                    currentRecord = friendList.IndexOf(Friend);
                }
            }
        }// end save_button_click() event handler method

        // method handles birthday textbox is numbers only
        private void birthdayTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        // method handles birthmonth textbox is numbers only
        private void birthMonthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        // method prevents use of comma in text box
        private static void preventCommas(KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
        // clears the text boxes
        private void clearBtn_Click_1(object sender, EventArgs e)
        {
            personTextBox.Text = "";
            likesTextBox.Text = "";
            dislikeTextBox.Text = "";
            birthdayTextBox.Text = "";
            birthMonthTextBox.Text = "";
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (ValidateData() == false)
            {
                return;
            }
            else
            {
                // prompt the user to proceed delete
                DialogResult dialogResult = MessageBox.Show("Do you wish to delete this friend?", "REMOVE FRIEND RECORD", MessageBoxButtons.YesNo);
                // if Yes button clicked, then proceed
                if (dialogResult == DialogResult.Yes)
                {
                    //proceed
                    // get all values to delete
                    string name = personTextBox.Text;
                    string likes = likesTextBox.Text;
                    string dob = dislikeTextBox.Text;
                    int day = Int32.Parse(birthdayTextBox.Text);
                    int month = Int32.Parse(birthMonthTextBox.Text);
                    // create new Friend object
                    Friends Friend = new Friends(name, likes, dob, day, month);
                    // add to the friendsList
                    friendList.RemoveAt(currentRecord);
                    // re-sort the friendsList
                    friendList.Sort();
                    // display newly sorted enrolment list
                    currentRecord = 0;
                    DisplayCurrentRecord();
                    // display newly sorted enrolment list
                    DisplayFriendData();
                    // and assign to currentRecord
                    //currentRecord = friendList.IndexOf(Friend);
                }
            }
        }

        private void birthdayButton_Click(object sender, EventArgs e)
        {
            
            if (month >= 0 && month<12)
            {
                month++;
                
            }
            else if (month >= 12)
            {
                month = 0;
            }
            DisplayFriendByMonth(month);
        }

        
    }       
}


