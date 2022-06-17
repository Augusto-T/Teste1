using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste1
{  
    class User : INotifyPropertyChanged
    {
        public string NomeUser { get; set; }
        public string Senha { get; set; }
       
   
    }
}
