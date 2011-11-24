using System.Collections.Generic;
using Machine.Specifications;
using developwithpassion.specifications.rhinomocks;
using prep.codekata;

namespace prep.specs
{
    [Subject(typeof(Anagrams))]
    public class AnagramsSpecs
    {
        public abstract class concern : Observes<Anagrams>
        {
        };
        public class when_loading_wordlist : concern
        {
            It should_load_80386_words = () =>
            {
                number = sut.count_of_all_words();
            };

            static int number;
        }
    }
}