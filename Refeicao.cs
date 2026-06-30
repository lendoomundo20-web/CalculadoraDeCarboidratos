using System;
using System.Collections.Generic;
using System.Linq;

class Refeicao
{
    public string name;

    public List<Componente> Componentes { get; } = new();

    public double carboidratosTotais
    {
        get
        {
            return Componentes.Sum(c => c.carboidratosAtuais);
        }
    }
}


