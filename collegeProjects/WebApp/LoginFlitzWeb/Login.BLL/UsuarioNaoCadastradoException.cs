﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.BLL
{
  public  class UsuarioNaoCadastradoException:Exception
    {
          public UsuarioNaoCadastradoException() { } 
 
          public UsuarioNaoCadastradoException(string message) { }
  
          public UsuarioNaoCadastradoException (string message, Exception inner)
                : base (message, inner)
          { }
    }
}
