using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1.dominio {
    class ModelExeption : Exception {
        public ModelExeption(string msg) : base(msg) {
        }
    }
}

