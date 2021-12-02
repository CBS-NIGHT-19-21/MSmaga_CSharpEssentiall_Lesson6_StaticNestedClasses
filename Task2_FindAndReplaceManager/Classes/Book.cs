class Book
{
    // Declare fields of class Book.
    private string _title;
    private string _text;
    private Note _notes;

    // Declare attributes of class Book.
    public string Title { get { return _title; } set { _title = value; } }
    public string Text { get { return _text; } set { _text = value; } }
    public Note Notes { get { return _notes; } set { _notes = value; } }


    // Declare the class Book constructor.
    public Book(string title, string text)
    {
        _title = title;
        _text = text;
        _notes = new Note();
    }

    /// <summary>
    /// Adds a note into the text and adds position of note into notes array.
    /// </summary>
    /// <param name="position"></param>
    public void MakeNote(int position)
    {
        /// Adds a note into the text.
        char[] buffer = this._text.ToCharArray();

        Array.Reverse(buffer, 0, 3);

        for (int i = 0; i < position; i++)
        {
            buffer[i] = _text[i];
        }

        buffer[position] = '*';
        buffer[position + 1] = '|';
        buffer[position + 2] = '|';
        buffer[position + 3] = '*';

        for (int i = position + 4; i < buffer.Length; i++)
        {
            buffer[i] = _text[i];
        }

        // Adds position of note into notes array.
        _notes.AddNote(position);

        _text = new string(buffer);
    }

    /// <summary>
    /// Shows Book instance attributes.
    /// </summary>
    public void Show()
    {

        Console.WriteLine("\nBook title: \n" + Title);
        Console.WriteLine("\nBook text: \n" + Text + "\n");
    }

    // Declare the Nested class Note.
    public class Note
    {
        /// Declare notes array.
        private long[] _notes;

        // Class Note constractor
        public Note()
        {
            _notes = new long[0];

        }

        /// Declare notes array indexer.
        public long this[int index]

        {
            get
            {
                return _notes[index];
            }
        }

        /// <summary>
        /// Adds the note into notes array.
        /// </summary>
        /// <param name="position"></param>
        public void AddNote(long position)
        {
            Array.Resize(ref _notes, _notes.Length + 1);

            _notes[_notes.Length - 1] = position;
        }

        /// <summary>
        /// Show position of note by its serial number
        /// </summary>
        /// <param name="marksNum"></param>
        public void ShowMark(int marksNum)
        {
            Console.Write("\nMark position: ");

            Console.Write($"{this[marksNum]}, ");
        }

        /// <summary>
        /// Shows position of all notes
        /// </summary>
        /// <param name="marksNum"></param>
        public void ShowMarks(int marksNum)
        {
            Console.Write("\nMarks position: ");
            for (int i = 0; i < marksNum; i++)
            {
                Console.Write($"{this[i]}, ");
            }
        }
    }
}