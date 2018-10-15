using System;
using System.Collections.Generic;
using System.Text;

namespace HometownZoo.Core
{
    /// <summary>
    /// Represents a any person (i.e. zoo member, employee, etc.)
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Primary key field
        /// </summary>
        public int PersonID { get; set; }

        /// <summary>
        /// The person's first AND last name
        /// </summary>
        public string Name { get; set; }
        
    }
}
