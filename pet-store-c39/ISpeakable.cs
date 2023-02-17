using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pet_store_c39;
internal interface ISpeakable {

    public string Speak();

}

internal interface INameable {

    public string Name { get; set; }

}

internal interface IPet : ISpeakable, INameable {
}
