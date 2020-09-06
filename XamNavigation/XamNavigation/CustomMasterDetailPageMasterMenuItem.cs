using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamNavigation
{

    public class CustomMasterDetailPageMasterMenuItem
    {
        public CustomMasterDetailPageMasterMenuItem()
        {
            TargetType = typeof(CustomMasterDetailPageMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}