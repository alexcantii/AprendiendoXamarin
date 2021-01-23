using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praticascreem.View.MasterDetail
{
    public class MymasterDetailPageMasterMenuItem
    {
        public MymasterDetailPageMasterMenuItem()
        {
            TargetType = typeof(MymasterDetailPageMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        
        public string Icono { get; set; }

        public Type TargetType { get; set; }
    }
}