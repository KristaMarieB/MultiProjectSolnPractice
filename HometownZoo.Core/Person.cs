using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HometownZoo.Core.Models
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
        [Column("Name")] // In the DB, the column is "Name"
        public string Name { get; set; }
        
    }
}
