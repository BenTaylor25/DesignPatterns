
namespace Prototype
{
    interface IPrototype
    {
        IPrototype Clone();
    }

    class DocOwner
    {
        public string name { get; set; }

        public DocOwner(string name)
        {
            this.name = name;
        }
    }

    class Document : IPrototype
    {
        public DocOwner owner { get; set; }
        public int pageCount { get; set; }
        public string text { get; set; }

        public Document()
        {
            owner = new DocOwner("unknown");
            pageCount = 0;
            text = "";
        }

        public Document(Document toClone)
        {
            this.owner = toClone.owner;   // reference
            // this.owner = new DocOwner("Ben");   // new object
            // this.owner = toClone.owner.Clone();   // deep clone

            this.pageCount = toClone.pageCount;
            this.text = toClone.text;
        }

        public IPrototype Clone()
        {
            return new Document(this);
        }
    }

    class Prototype
    {
        public static void Execute()
        {
            Document doc1 = new();
            doc1.owner = new DocOwner("Ben");
            doc1.pageCount = 5;
            doc1.text = "hello";

            // Is there a way to do this without casting?
            Document doc2 = (Document)doc1.Clone();

            doc1.owner.name = "Not Ben";   // changes for doc2 too because ref copy
            doc1.pageCount = 15;
            doc1.text = "world";

            // Modified Document
            Console.WriteLine(doc1.owner.name);
            Console.WriteLine(doc1.pageCount);
            Console.WriteLine(doc1.text);

            Console.WriteLine();

            // Backup Document
            // (with new owner name)
            Console.WriteLine(doc2.owner.name);
            Console.WriteLine(doc2.pageCount);
            Console.WriteLine(doc2.text);
        }
    }
}
