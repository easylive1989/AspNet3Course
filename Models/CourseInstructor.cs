﻿using System;
using System.Collections.Generic;

namespace AspNet3Course.Models
{
    public partial class CourseInstructor
    {
        public int CourseId { get; set; }
        public int InstructorId { get; set; }

        public virtual Course Course { get; set; }
        public virtual Person Instructor { get; set; }
    }
}
