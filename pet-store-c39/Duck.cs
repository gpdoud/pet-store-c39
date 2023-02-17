using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pet_store_c39;
internal class Duck : IPet {

    public string Name { get; set; } = string.Empty; 

    public string Speak() {
        return "Quack!";
    }

    public void GetOutOfTheRoad() {

    }

    public void DontPoopOnYourOwner() {

    }
}
