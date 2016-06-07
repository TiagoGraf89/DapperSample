using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperSample
{
    class ShowroomModel
    {
        public Guid ShowroomId { get; set; }
        public String ShowroomName { get; set; }
        public Boolean IsActive { get; set; }

        public ShowroomModel()
        { }
        public ShowroomModel(string name)
        {
            this.ShowroomId = Guid.NewGuid();
            this.ShowroomName = string.Join(" ", name, this.ShowroomId.ToString());
        }
    }
}
