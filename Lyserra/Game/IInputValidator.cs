using System;

namespace Lyserra.Game
{
    // interface for input validation
    public interface IInputValidator
    {
        bool ValidateName(string name);
        bool ValidateInput(string input);
        string SanitizeInput(string input);
    }
}