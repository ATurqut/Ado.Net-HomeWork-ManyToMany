using System.Collections.Generic;
using WpfApp3;

namespace WpfApp3;

internal class Author
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Book> Books { get; set; } = new();
    public override string ToString() => Name;
}
