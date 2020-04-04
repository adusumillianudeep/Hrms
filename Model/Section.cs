using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SectionDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Available { get; set; }

        public int ParentId { get; set; }

        public string ParentName { get; set; }

        public List<SectionFieldDto> Fields { get; set; }
    }

    public class SectionFieldDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Required { get; set; }
        public bool Available { get; set; }
    }

    public class CustomSectionDto {
        public int Id { get; set; }
        public string Name { get; set; }

        public int ParentId { get; set; }
    }
}
