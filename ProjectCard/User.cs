namespace ProjectCard
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [Key]
        public string UserNameID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        public DateTime LastLogin { get; set; }

        public DateTime DayOfCreate { get; set; }

        public DateTime PasswordChange { get; set; }
    }
}
