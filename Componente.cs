using System;
using System.Collections.Generic;
using System.Linq;


class Componente
{
    public string name;

    public double peso;
    public double carboidratosPor100g;

    public double carboidratosAtuais
    {
        get
        {
            return (carboidratosPor100g * peso) / 100.0;
        }
    }
}
