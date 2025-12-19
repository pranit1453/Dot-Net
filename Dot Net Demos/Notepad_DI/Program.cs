namespace Notepad_DI
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
           
            Console.WriteLine("Welcome to Notepad...");

            NotePad notepad = new NotePad(null);
            notepad.SpellCheck();

            GermanSpellChecker gsp = new GermanSpellChecker();
            NotePad germansp=new NotePad(gsp);
            germansp.SpellCheck();

            HindiSpellChecker hsp = new HindiSpellChecker();
            NotePad hindisp=new NotePad(hsp);
            hindisp.SpellCheck();
           
        }
    }

    public class NotePad
    {
        /*
         Const values are implicitly static and limited to basic types, while readonly variables
         can be instance, static, or reference types.
         Const variables are stored in metadata and readonly variables are stored in the memory heap*/
        private  readonly ISpellChecker _checker;
        public NotePad(ISpellChecker checker)
        {
            if(checker == null)
            {
                _checker = SpellCheckFactory.GetSomeSpellChecker("en");
            }
            else
            {
                _checker = checker;
            } 
        }
        public void SpellCheck()
        {
            _checker.DoSpellChecker();
        }
    }
    public class SpellCheckFactory
    {
      
        public static ISpellChecker GetSomeSpellChecker(String type)
        {
            switch(type.ToUpper())
            {
                case "EN":
                    return new EnglishSpellChecker();
                case "GE":
                    return new GermanSpellChecker();
                default: 
                    return new EnglishSpellChecker();

            }
        }

    }
    public interface ISpellChecker
    {
        public void DoSpellChecker();
    }
    public class EnglishSpellChecker:ISpellChecker
    {
        public void DoSpellChecker()
        {
            Console.WriteLine("Spell Check in English Done....");
        }
    }

    public class GermanSpellChecker:ISpellChecker
    {
        public void DoSpellChecker()
        {
            Console.WriteLine("Spell Check in German Done....");
        }
    }

    public class HindiSpellChecker:ISpellChecker
    {
        public void DoSpellChecker()
        {
            Console.WriteLine("Spell Check in Hindi Done...");
        }
    }
}
