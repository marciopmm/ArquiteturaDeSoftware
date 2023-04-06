using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample01
{
    #region Ingredientes Abstratos
    public abstract class Massa 
    {
    }

    public abstract class Molho
    {
    }

    public abstract class Mussarela
    {
    }

    public abstract class Alho
    {
    }

    public abstract class Pimentao
    {
    }

    public abstract class Manjericao
    {
    }

    public abstract class Calabresa
    {
    }

    public abstract class Azeitona
    {
    }

#endregion

    #region Ingredientes Concretos

    public class MassaFinaCrocante : Massa
    {
    }

    public class MassaGrossaTemperada : Massa
    {
    }

    public class MolhoRefogadoTomate : Molho
    {
    }

    public class MolhoExtratoTomate : Molho
    {
    }

    public class MussarelaBranca : Mussarela
    {
    }

    public class MussarelaAmarela : Mussarela
    {
    }

    public class CalabresaMoida : Calabresa { }

    public class CalabresaFatiada : Calabresa { }

    public class PimentaoPicado : Pimentao { }

    public class PimentaoFatiado : Pimentao { }

    public class AlhoFritoEmCubos : Alho { }

    public class AlhoFritoEmFatias : Alho { }

    public class ManjericaoDesidratado : Manjericao { }

    public class ManjericaoFresco : Manjericao { }

    public class AzeitonaVerde : Azeitona { }

    public class AzeitonaPreta : Azeitona { }

    #endregion
}
