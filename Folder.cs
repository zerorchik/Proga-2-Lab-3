using System;

namespace proga_2_lab_3_1
{
    public class Folder : Base<Folder>
    {
        public string Name { get; set; }
        public int Num { get; set; }

        // Попередня папка
        private Guid _prevFoldId;
        public Folder PreviousFolder
        {
            get { return Folder.Items[_prevFoldId]; }
            set { _prevFoldId = value.Id; }
        }

        public override string ToString()
        {
            return "|--" + Name + "\t(#" + Num + ")"; 
        }
    }
}
