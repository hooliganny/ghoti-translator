namespace GhotiTranslator.Rules
{
    public static class Rules
    {
        // TODO: expand on this list, find out if it necessarily works both ways?
        // TODO: make this work for when accessed via reversed spellingRules (see else if statement in "Spelling rules used" section)
        // TODO: work out what to do with the short vowels with same key as the long vowels (i, oo, u)
        public static readonly Dictionary<string, Dictionary<string, string>> Pronunciation = new()
        {
            { "b", new Dictionary<string, string> { { "b", "the 'b' in 'ball'" }, { "bb", "the 'bb' in 'ribbon'" } } },
            { "d", new Dictionary<string, string> { { "d", "the 'd' in 'dog'" }, { "dd", "the 'dd' in 'add'" }, { "ed", "the 'ed' in 'filled'" } } },
            { "f", new Dictionary<string, string> { { "f", "the 'f' in 'fan'" }, { "ff", "the 'ff' in 'cliff'" }, { "ph", "the 'ph' in 'phone'" }, { "gh", "the 'gh' in 'laugh'" }, { "lf", "the 'lf' in 'calf'" }, { "ft", "the 'ft' in 'often'" } } },
            { "g", new Dictionary<string, string> { { "g", "the 'g' in 'grapes'" }, { "gg", "the 'gg' in 'egg'" }, { "gh", "the 'gh' in 'ghost'" }, { "gu", "the 'gu' in 'guest'" }, { "gue", "the 'gue' in 'catalogue'" } } },
            { "h", new Dictionary<string, string> { { "h", "the 'h' in 'hat'" }, { "wh", "the 'wh' in 'who'" } } },
            { "j", new Dictionary<string, string> { { "j", "the 'j' in 'jellyfish'" }, { "ge", "the 'ge' in 'cage'" }, { "g", "the 'g' in 'giraffe'" }, { "dge", "the 'dge' in 'edge'" }, { "di", "the 'di' in 'soldier'" }, { "gg", "the 'gg' in 'exaggerate'" } } },
            { "k", new Dictionary<string, string> { { "k", "the 'k' in 'kite'" }, { "c", "the 'c' in 'cat'" }, { "ch", "the 'ch' in 'Christmas'" }, { "cc", "the 'cc' in 'acclaim'" }, { "lk", "the 'lk' in 'folk'" }, { "qu", "the 'qu' in 'bouquet'" }, { "q", "the 'q' in 'queen'" }, { "ck", "the 'ck' in 'back'" }, { "x", "the 'x' in 'box'" } } },
            { "l", new Dictionary<string, string> { { "l", "the 'l' in 'leaf'" }, { "ll", "the 'll' in 'spell'" } } },
            { "m", new Dictionary<string, string> { { "m", "the 'm' in 'monkey'" }, { "mm", "the 'mm' in 'summer'" }, { "mb", "the 'mb' in 'climb'" }, { "mn", "the 'mn' in 'autumn'" }, { "lm", "the 'lm' in 'palm'" } } },
            { "n", new Dictionary<string, string> { { "n", "the 'n' in 'nest'" }, { "nn", "the 'nn' in 'funny'" }, { "kn", "the 'kn' in 'knight'" }, { "gn", "the 'gn' in 'gnat'" }, { "pn", "the 'pn' in 'pneumonia'" } } },
            { "ng", new Dictionary<string, string> { { "ng", "the 'ng' in 'ring'" }, { "n", "the 'n' in 'sink'" }, { "ngue", "the 'ngue' in 'tongue'" } } },
            { "p", new Dictionary<string, string> { { "p", "the 'p' in 'pig'" }, { "pp", "the 'pp' in 'happy'" } } },
            { "r", new Dictionary<string, string> { { "r", "the 'r' in 'robot'" }, { "rr", "the 'rr' in 'carrot'" }, { "wr", "the 'wr' in 'wrong'" }, { "rh", "the 'rh' in 'rhyme'" } } },
            { "s", new Dictionary<string, string> { { "s", "the 's' in 'sun'" }, { "ss", "the 'ss' in 'mess'" }, { "c", "the 'c' in 'circus'" }, { "sc", "the 'sc' in 'science'" }, { "ps", "the 'ps' in 'psychology'" }, { "st", "the 'st' in 'listen'" }, { "ce", "the 'ce' in 'rice'" }, { "se", "the 'se' in 'horse'" }, { "si", "the 'si' in 'division'" }, { "z", "the 'z' in 'azure'" } } },
            { "t", new Dictionary<string, string> { { "t", "the 't' in 'tap'" }, { "tt", "the 'tt' in 'batter'" }, { "th", "the 'th' in 'Thomas'" }, { "ed", "the 'ed' in 'tapped'" } } },
            { "v", new Dictionary<string, string> { { "v", "the 'v' in 'van'" }, { "f", "the 'f' in 'of'" }, { "ph", "the 'ph' in 'Stephen'" }, { "ve", "the 've' in 'five'" } } },
            { "w", new Dictionary<string, string> { { "w", "the 'w' in 'web'" }, { "g", "the 'g' in 'grapes'" },  { "wh", "the 'wh' in 'why'" }, { "u", "the 'u' in 'quick'" }, { "o", "the 'o' in 'choir'" } } },
            { "y", new Dictionary<string, string> { { "y", "the 'y' in 'yo-yo'" }, { "i", "the 'i' in 'opinion'" }, { "j", "the 'j' in 'hallelujah'" } } },
            { "z", new Dictionary<string, string> { { "z", "the 'z' in 'zebra'" }, { "zz", "the 'zz' in 'buzz'" }, { "s", "the 's' in 'has'" }, { "ss", "the 'ss' in 'scissors'" }, { "x", "the 'x' in 'xylophone'" }, { "ze", "the 'ze' in 'maze'" }, { "se", "the 'se' in 'cheese'" } } },

            // Digraphs
            { "ch", new Dictionary<string, string> { { "ch", "the 'ch' in 'cheese'" }, { "tch", "the 'tch' in 'watch'" }, { "tu", "the 'tu' in 'future'" }, { "ti", "the 'ti' in 'question'" }, { "te", "the 'te' in 'righteous'" } } },
            { "sh", new Dictionary<string, string> { { "sh", "the 'sh' in 'shark'" }, { "ce", "the 'ce' in 'ocean'" }, { "s", "the 's' in 'sure'" }, { "ci", "the 'ci' in 'special'" }, { "si", "the 'si' in 'tension'" }, { "ch", "the 'ch' in 'machine'" }, { "sci", "the 'sci' in 'conscience'" }, { "ti", "the 'ti' in 'station'" } } },
            { "th", new Dictionary<string, string> { { "th", "the 'th' in 'thongs'" } } },

            // Short Vowels
            { "a", new Dictionary<string, string> { { "a", "the 'a' in 'cat'" }, { "ai", "the 'ai' in 'plaid'" } } },
            { "e", new Dictionary<string, string> { { "e", "the 'e' in 'egg'" }, { "ea", "the 'ea' in 'bread'" }, { "u", "the 'u' in 'bury'" }, { "ie", "the 'ie' in 'friend'" }, { "ai", "the 'ai' in 'said'" }, { "a", "the 'a' in 'many'" }, { "eo", "the 'eo' in 'leopard'" }, { "ei", "the 'ei' in 'heifer'" }, { "ae", "the 'ae' in 'aesthetic'" }, { "ay", "the 'ay' in 'say'" } } },
            { "i", new Dictionary<string, string> { { "i", "the 'i' in 'igloo'" }, { "e", "the 'e' in 'England'" }, { "o", "the 'o' in 'women'" }, { "u", "the 'u' in 'busy'" }, { "ui", "the 'ui' in 'build'" }, { "y", "the 'y' in 'hymn'" }, { "ie", "the 'ie' in 'sieve'" } } },
            { "o", new Dictionary<string, string> { { "o", "the 'o' in 'orange'" }, { "a", "the 'a' in 'swan'" }, { "ho", "the 'ho' in 'honest'" } } },
            { "u", new Dictionary<string, string> { { "u", "the 'u' in 'mug'" }, { "o", "the 'o' in 'monkey'" }, { "oo", "the 'oo' in 'flood'" }, { "ou", "the 'ou' in 'trouble'" } } },
            { "oo", new Dictionary<string, string> { { "oo", "the 'oo' in 'book'" }, { "u", "the 'u' in 'bush'" }, { "ou", "the 'ou' in 'could'" }, { "o", "the 'o' in 'wolf'" } } },

            // Long Vowels
            { "ai", new Dictionary<string, string> { { "ai", "the 'ai' in 'snail'" }, { "a", "the 'a' in 'baby'" }, { "eigh", "the 'eigh' in 'weigh'" }, { "aigh", "the 'aigh' in 'straight'" }, { "ay", "the 'ay' in 'hay'" }, { "et", "the 'et' in 'croquet'" }, { "ei", "the 'ei' in 'vein'" }, { "au", "the 'au' in 'gauge'" }, { "ea", "the 'ea' in 'break'" }, { "ey", "the 'ey' in 'they'" } } },
            { "ee", new Dictionary<string, string> { { "ee", "the 'ee' in 'bee'" }, { "e", "the 'e' in 'me'" }, { "ea", "the 'ea' in 'seat'" }, { "y", "the 'y' in 'lady'" }, { "ey", "the 'ey' in 'key'" }, { "ie", "the 'ie' in 'brief'" }, { "i", "the 'i' in 'ski'" }, { "ei", "the 'ei' in 'receive'" }, { "eo", "the 'eo' in 'people'" }, { "ay", "the 'ay' in 'quay'" } } },
            // { "i", new Dictionary<string, string> { { "i", "the 'i' in 'spider'" }, { "y", "the 'y' in 'fly'" }, { "igh", "the 'igh' in 'night'" }, { "ie", "the 'ie' in 'pie'" }, { "uy", "the 'uy' in 'buy'" }, { "ye", "the 'ye' in 'rye'" }, { "ai", "the 'ai' in 'aisle'" }, { "is", "the 'is' in 'island'" }, { "eigh", "the 'eigh' in 'height'" }, { "i-e", "the 'i-e' in 'kite'" } } },
            { "oa", new Dictionary<string, string> { { "oa", "the 'oa' in 'boat'" }, { "o", "the 'o' in 'open'" }, { "oe", "the 'oe' in 'toe'" }, { "ow", "the 'ow' in 'low'" }, { "ough", "the 'ough' in 'though'" }, { "eau", "the 'eau' in 'beau'" }, { "oo", "the 'oo' in 'brooch'" }, { "ew", "the 'ew' in 'sew'" } } },
            // { "oo", new Dictionary<string, string> { { "oo", "the 'oo' in 'moon'" }, { "ew", "the 'ew' in 'screw'" }, { "ue", "the 'ue' in 'blue'" }, { "oe", "the 'oe' in 'shoe'" }, { "ough", "the 'ough' in 'through'" }, { "ui", "the 'ui' in 'fruit'" }, { "o", "the 'o' in 'who'" }, { "oeu", "the 'oeu' in 'manoeuvre'" }, { "ou", "the 'ou' in 'croup'" } } },
            // { "u", new Dictionary<string, string> { { "u", "the 'u' in 'uniform'" }, { "you", "the 'you' in 'you'" }, { "ew", "the 'ew' in 'few'" }, { "iew", "the 'iew' in 'view'" }, { "yu", "the 'yu' in 'yule'" }, { "eue", "the 'eue' in 'queue'" }, { "eau", "the 'eau' in 'beauty'" }, { "ieu", "the 'ieu' in 'adieu'" }, { "eu", "the 'eu' in 'feud'" } } },

            { "oi", new Dictionary<string, string> { { "oi", "the 'oi' in 'coin'" }, { "oy", "the 'oy' in 'boy'" }, { "uoy", "the 'uoy' in 'buoy'" } } },
            { "ow", new Dictionary<string, string> { { "ow", "the 'ow' in 'cow'" }, { "ou", "the 'ou' in 'shout'" }, { "ough", "the 'ough' in 'bough'" } } },
            { "er", new Dictionary<string, string> { { "er", "the 'er' in 'ladder'" }, { "ar", "the 'ar' in 'dollar'" }, { "our", "the 'our' in 'honour'" }, { "or", "the 'or' in 'doctor'" }, { "i", "the 'i' in 'dolphin'" }, { "e", "the 'e' in 'ticket'" }, { "u", "the 'u' in 'cactus'" }, { "ur", "the 'ur' in 'augur'" }, { "re", "the 're' in 'centre'" }, { "eur", "the 'eur' in 'chauffeur'" } } },

            // R-Controlled Vowels
            { "air", new Dictionary<string, string> { { "air", "the 'air' in 'chair'" }, { "are", "the 'are' in 'square'" }, { "ear", "the 'ear' in 'pear'" }, { "ere", "the 'ere' in 'where'" }, { "eir", "the 'eir' in 'their'" }, { "ayer", "the 'ayer' in 'prayer'" } } },
            { "ar", new Dictionary<string, string> { { "ar", "the 'ar' in 'car'" }, { "a", "the 'a' in 'bath'" }, { "au", "the 'au' in 'laugh'" }, { "er", "the 'er' in 'sergeant'" }, { "ear", "the 'ear' in 'heart'" } } },
            { "ir", new Dictionary<string, string> { { "ir", "the 'ir' in 'bird'" }, { "er", "the 'er' in 'term'" }, { "ur", "the 'ur' in 'burn'" }, { "ear", "the 'ear' in 'pearl'" }, { "or", "the 'or' in 'word'" }, { "our", "the 'our' in 'journey'" }, { "yr", "the 'yr' in 'myrtle'" } } },
            { "aw", new Dictionary<string, string> { { "aw", "the 'aw' in 'paw'" }, { "a", "the 'a' in 'ball'" }, { "or", "the 'or' in 'fork'" }, { "oor", "the 'oor' in 'door'" }, { "ore", "the 'ore' in 'more'" }, { "oar", "the 'oar' in 'board'" }, { "our", "the 'our' in 'four'" }, { "augh", "the 'augh' in 'taught'" }, { "ar", "the 'ar' in 'war'" }, { "ough", "the 'ough' in 'bought'" }, { "au", "the 'au' in 'sauce'" } } },
            { "ear", new Dictionary<string, string> { { "ear", "the 'ear' in 'ear'" }, { "eer", "the 'eer' in 'steer'" }, { "ere", "the 'ere' in 'here'" }, { "ier", "the 'ier' in 'pier'" } } },
            { "ure", new Dictionary<string, string> { { "ure", "the 'ure' in 'cure'" }, { "our", "the 'our' in 'tourist'" } } }
        };

        public static readonly Dictionary<string, HashSet<string>> Spelling = new()
        {
            { "b", new HashSet<string> { "b", "bb" } },
            { "d", new HashSet<string> { "d", "dd", "ed" } },
            { "f", new HashSet<string> { "f", "ff", "ph", "gh", "lf", "ft" } },
            { "g", new HashSet<string> { "g", "gg", "gh", "gu", "gue" } },
            { "h", new HashSet<string> { "h", "wh" } },
            { "j", new HashSet<string> { "j", "ge", "g", "dge", "di", "gg" } },
            { "k", new HashSet<string> { "k", "c", "ch", "cc", "lk", "qu", "q", "ck", "x" } },
            { "l", new HashSet<string> { "l", "ll" } },
            { "m", new HashSet<string> { "m", "mm", "mb", "mn", "lm" } },
            { "n", new HashSet<string> { "n", "nn", "kn", "gn", "pn" } },
            { "ng", new HashSet<string> { "ng", "n", "ngue" } },
            { "p", new HashSet<string> { "p", "pp" } },
            { "r", new HashSet<string> { "r", "rr", "wr", "rh" } },
            { "s", new HashSet<string> { "s", "ss", "c", "sc", "ps", "st", "ce", "se", "si", "z" } },
            { "t", new HashSet<string> { "t", "tt", "th", "ed" } },
            { "v", new HashSet<string> { "v", "f", "ph", "ve" } },
            { "w", new HashSet<string> { "w", "wh", "u", "o" } },
            { "y", new HashSet<string> { "y", "i", "j" } },
            { "z", new HashSet<string> { "z", "zz", "s", "ss", "x", "ze", "se" } },

            { "ch", new HashSet<string> { "ch", "tch", "tu", "ti", "te" } },
            { "sh", new HashSet<string> { "sh", "ce", "s", "ci", "si", "ch", "sci", "ti" } },
            { "th", new HashSet<string> { "th" } },

            { "a", new HashSet<string> { "a", "ai" } },
            { "e", new HashSet<string> { "e", "ea", "u", "ie", "ai", "a", "eo", "ei", "ae", "ay" } },
            { "i", new HashSet<string> { "i", "e", "o", "u", "ui", "y", "ie" } },
            { "o", new HashSet<string> { "o", "a", "ho" } },
            { "u", new HashSet<string> { "u", "o", "oo", "ou" } },
            { "oo", new HashSet<string> { "oo", "u", "ou", "o" } },

            { "ai", new HashSet<string> { "ai", "a", "eigh", "aigh", "ay", "et", "ei", "au", "ea", "ey" } },
            { "ee", new HashSet<string> { "ee", "e", "ea", "y", "ey", "oe", "ie", "i", "ei", "eo", "ay" } },
            // { "i", new HashSet<string> {  "i", "y", "igh", "ie", "uy", "ye", "ai", "is", "eigh" } },
            { "oa", new HashSet<string> { "oa", "o", "oe", "ow", "ough", "eau", "oo", "ew" } },
            // { "oo", new HashSet<string> { "oo", "ew", "ue", "oe", "ough", "ui", "o", "oeu", "ou" } },
            // { "u", new HashSet<string> { "u", "ou", "ew", "iew", "yu", "eue", "eau", "ieu", "eu" } },

            { "oi", new HashSet<string> { "oi", "oy", "uoy" } },
            { "ow", new HashSet<string> { "ow", "ou", "ough" } },
            { "er", new HashSet<string> { "er", "ar", "our", "or", "i", "e", "u", "ur", "re", "eur" } },

            { "air", new HashSet<string> { "air", "are", "ear", "ere", "eir", "ayer" } },
            { "ar", new HashSet<string> { "ar", "a", "au", "er", "ear" } },
            { "ir", new HashSet<string> { "ir", "er", "ur", "ear", "or", "our", "yr" } },
            { "aw", new HashSet<string> { "aw", "a", "or", "oor", "ore", "oar", "our", "augh", "ar", "ough", "au" } },
            { "ear", new HashSet<string> { "ear", "eer", "ere", "ier" } },
            { "ure", new HashSet<string> { "ure", "our" } },
        };
    }
}