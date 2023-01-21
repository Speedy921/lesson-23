using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_23
{
    public abstract class CloneableType
    {
        //поддерживать этот "полиморфный интерфейс"
        //могут только произведные типа
        //классы в других иерархиях не имют доступа
        //к данному абстрактному члену
        public abstract object Clone();

    }
}
