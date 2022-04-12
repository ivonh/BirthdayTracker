using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayTracker
{
    /// <summary>
    /// Friend class
    /// This class used to create instances to store and read content from external csv file
    /// Data: Name, Likes, Dislikes, Day, Month
    /// Methods: Constructor, Get/Set Methods for the data, ToString, ToCSVString, CompareTo
    /// </summary>
    /// <remarks>Ivon Harris 27-Feb-2022</remarks>
    public class Friends : IComparable<Friends>
    {
        /// <summary>
        /// Public proerties for each data field
        /// built in get and set methods
        /// </summary>
        // public properties
        public string Name { get; set; }
        public string Likes { get; set; }
        public string Dislikes { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }

        /// <summary>
        /// Friends Constructor method
        /// Purpose: Creates instance of the Class
        /// </summary>
        /// <param name="name">name of your friend</param>
        /// <param name="likes">what they like</param>
        /// <param name="dislikes">what they dislike</param>
        /// <param name="day">the day of their birthday</param>
        /// <param name="month">the month of their birthday</param>
        // set up parametised constructor method

        public Friends(string name, string likes, string dislikes, int day, int month)
        {
            Name = name;
            Likes = likes;
            Dislikes = dislikes;
            Day = day;
            Month = month;
        }
        
        /// <summary>
        /// ToString () method
        /// Purpose: provides a string version concatenated instance variables
        /// </summary>
        /// <returns>string of instance values</returns>
        // public ToString() method
        public override string ToString()
        {
            string friendString = Name + "\t" + Likes + "\t" + Dislikes + "\t" + Day + "\t" + Month + "\t\n";
            return friendString;
        }
        /// <summary>
        /// CompareTo() method
        /// Purpose: Compares instance with other Enrolment objects
        /// </summary>
        /// <param name="other"></param>
        /// <returns>int 0, 1 or other</returns>
        // implemented CompareTo() method
        public int CompareTo(Friends other)
        {
            return this.Name.CompareTo(other.Name);
        }
        /// <summary>
        /// ToCSVString() method
        /// Purpose: Provide a CSV string format of variables to write to CSV file
        /// </summary>
        /// <returns>string csv formatted values</returns>
        // implemented ToCSVString() method
        public string ToCSVString()
        {
            return Name + "," + Likes + "," + Dislikes + "," + Day + "," + Month  ;
        }

    }// end friend class

}// end namespace
