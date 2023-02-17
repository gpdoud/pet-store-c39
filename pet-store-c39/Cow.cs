using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pet_store_c39;
internal class Cow : IPet {

    public string Name { get; set; } = string.Empty;

    public string Speak() {
        return "Mooooooooooooo!";
    }

    public void MilkYourself() {

    }

    public void GetYourOwnHay() {

    }
}
