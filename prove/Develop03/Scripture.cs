using System;
public class Scripture {
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text) {
        _reference = reference;
        _words = new List<Word>();
        foreach (string word in text.Split(' ')) {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide) {
        Random random = new Random();
        
        // Hide the specified number of words
        // Skip the words that are already hidden
        for (int i = 0; i < numberToHide; i++) {
            int index = random.Next(_words.Count);
            while (_words[index].IsHidden()) {
                index = random.Next(_words.Count);
            }
            _words[index].Hide();

            // If all words are hidden, break out of the loop
            if (IsCompletelyHidden()) {
                break;
            }
        }
    }

    public string GetDisplayText() {
        string displayText = _reference.GetDisplayText() + " ";

        foreach (Word word in _words) {
            displayText += word.DisplayText() + " ";
        }
        return displayText.Trim();
    }

    public bool IsCompletelyHidden() {
        foreach (Word word in _words) {
            if (!word.IsHidden()) {
                return false;
            }
        }
        return true;
    }
}