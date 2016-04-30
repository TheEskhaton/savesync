namespace Bananasync.Core.Misc
{
    class Table : System.Attribute
    {
        public string Tablename { get; private set; }

        private Table()
        {
            
        }

        public Table(string tablename)
        {
            Tablename = tablename;
        }
    }
}
