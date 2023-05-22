using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson19.UserInterface;
// Класс где будет хранится название кнопки, и сама кнопка (диллегат)
public class MenuOption
{
    public string Title { get; set; }
    public Action Action { get; set; }
}
