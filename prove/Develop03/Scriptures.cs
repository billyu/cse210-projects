using System;
public class Scriptures
{
    private List<Scripture> _scriptures;

    public Scriptures()
    {
        _scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all this through him who gives me strength."),
            new Scripture(new Reference("Psalm", 23, 1), "The Lord is my shepherd, I lack nothing."),
            new Scripture(new Reference("Romans", 8, 28), "And we know that in all things God works for the good of those who love him, who have been called according to his purpose."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."),
            new Scripture(new Reference("Isaiah", 40, 31), "But those who hope in the Lord will renew their strength. They will soar on wings like eagles; they will run and not grow weary, they will walk and not be faint."),
            new Scripture(new Reference("Jeremiah", 29, 11), "For I know the plans I have for you, declares the Lord, plans to prosper you and not to harm you, plans to give you hope and a future."),
            new Scripture(new Reference("Matthew", 6, 33), "But seek first his kingdom and his righteousness, and all these things will be given to you as well."),
            new Scripture(new Reference("Ephesians", 2, 8, 9), "For it is by grace you have been saved, through faith—and this is not from yourselves, it is the gift of God—not by works, so that no one can boast."),
            new Scripture(new Reference("John", 14, 6), "Jesus answered, 'I am the way and the truth and the life. No one comes to the Father except through me.'") 
        };
    }

    public Scripture GetRandomScripture()
    {
        Random random = new Random();
        int index = random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}