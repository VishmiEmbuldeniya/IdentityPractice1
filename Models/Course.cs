using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace IdentityPractice.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public String? Title { get; set; }
        
        [JsonIgnore]
        public List<Enrollment>? Enrollments { get; set; }
    }
}