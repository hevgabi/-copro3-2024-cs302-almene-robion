using System;

namespace Lyserra.Game
{
    public class GameException : Exception
    {
        public GameException() : base() { }

        public GameException(string message) : base(message) { }

        public GameException(string message, Exception innerException)
            : base(message, innerException) { }
    }

    // exception para sa invalid name input to pre
    public class InvalidNameException : GameException
    {
        public InvalidNameException()
            : base("Invalid name format. Name must be 2-20 characters and contain only letters and spaces.") { }

        public InvalidNameException(string message) : base(message) { }
    }

    // invalid menu choice naman to
    public class InvalidMenuChoiceException : GameException
    {
        public InvalidMenuChoiceException()
            : base("Invalid menu choice selected.") { }

        public InvalidMenuChoiceException(string message) : base(message) { }
    }

    // empty input exception
    public class EmptyInputException : GameException
    {
        public EmptyInputException()
            : base("Input cannot be empty or whitespace.") { }

        public EmptyInputException(string message) : base(message) { }
    }
}