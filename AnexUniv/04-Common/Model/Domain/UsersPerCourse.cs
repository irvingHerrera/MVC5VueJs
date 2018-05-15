﻿using Model.Auth;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Domain
{
    public class UsersPerCourse
    {
        public int Id { get; set; }
        [DefaultValue(false)]
        public bool Completed { get; set; }

        public Course Course { get; set; }
        public int CourseId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }
    }
}