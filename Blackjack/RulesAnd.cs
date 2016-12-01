﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Class1
    {
        public void Rules()
        {
            Console.WriteLine(" THE DEAL");
            Console.WriteLine("---------\n");
            Console.WriteLine("If the player is dealt a card with the value of 10 along with");
            Console.WriteLine("an ace during the deal, the player has 'blackjack'. They automaticlly");
            Console.WriteLine("win 150% return, and their turn is over. Before the turn starts the dealer checks");
            Console.WriteLine("their face down card, and if they have blackjack, everyone loses and");
            Console.WriteLine("the turn is over.");
            Console.WriteLine("");
            Console.WriteLine(" THE TURN");
            Console.WriteLine("----------\n");
            Console.WriteLine("The first player on the left decides wether they are going to 'hit'");
            Console.WriteLine("(ask for another card), or stay (not ask for another card). This will");
            Console.WriteLine("be based on how close they are to 21. The dealer must keep drawing cards");
            Console.WriteLine("until they are at or above 17, then they must stop. ");
            Console.WriteLine("");
            Console.WriteLine("SPLITTING PAIRS");
            Console.WriteLine("----------------\n");
            Console.WriteLine("If a players first two cards are the same denomination, they may");
            Console.WriteLine("choose to split them and treat them as two seperate hands. The player");
            Console.WriteLine("then plays each hand, one at a time.");
            Console.WriteLine("");
            Console.WriteLine("DOUBLING DOWN");
            Console.WriteLine("--------------\n");
            Console.WriteLine("The plyer also hs the option of doubling down when the total of their");
            Console.WriteLine("first two cards is 9, 10, or 11. They will then put double their");
            Console.WriteLine("money on the hand and play the rest of the turn like normal.");
            Console.WriteLine("");
            Console.WriteLine("INSURANCE");
            Console.WriteLine("----------\n");
            Console.WriteLine("");
            Console.WriteLine("If the dealer's face up card is an ace, all players also have the ");
            Console.WriteLine("opportunity to make a side bet, refering to the possibility that");
            Console.WriteLine("the dealer's face down card might be a ten (protecting them from");
            Console.WriteLine("the dealer getting a blackjack");
            Console.WriteLine("");
            Console.WriteLine("SETTLING UP");
            Console.WriteLine("------------");
            Console.WriteLine("The round is over once every player (including the dealer) has ");
            Console.WriteLine("played their turn. If the player loses, their entire bet is");
            Console.WriteLine("collected and never returned. Regular player wins pay out 1:1,");
            Console.WriteLine("blackjacks pat out 150% and each hand of a split pays 1:1,");
            Console.WriteLine("even if the split resulted in a blackjack.");
            Console.WriteLine("");
            Console.WriteLine("SHUFFLING");
            Console.WriteLine("----------");
            Console.WriteLine("");
            Console.WriteLine("After each round, the cards are collected and set aside by the");
            Console.WriteLine("dealer into a discard pile. Cards will continue to be drawn from");
            Console.WriteLine("the shoe until the dealer reaches a marked point, at which time");
            Console.WriteLine("they will shuffle the discards back into the main deck, cut the");
            Console.WriteLine("deck, insert the mark back into the shoe, and resume play.");
            Console.WriteLine("");
            Console.WriteLine("                            ===============");
            Console.WriteLine("                            |  BLACKJACK  |");
            Console.WriteLine("                            ===============");
            Console.WriteLine(@"                   .------.------.------.------.");
            Console.WriteLine(@"                   |A_  _ |A /\  |A _   |A .   |");
            Console.WriteLine(@"                   |( \/ )| /  \ | ( )  | / \  |");
            Console.WriteLine(@"                   | \  / | \  / |(_x_) |(_,_) |");
            Console.WriteLine(@"                   |  \/ A|  \/ A|  Y  A|  I  A|");
            Console.WriteLine(@"                   `------^------^------'------'");
            Console.WriteLine(@"");
            Console.WriteLine(@"                               _");
            Console.WriteLine(@"       ,'`.    _  _    /\    _(_)_");
            Console.WriteLine(@"      (_,._)  ( `' )  <  >  (_)+(_)");
            Console.WriteLine(@"        /\     `.,'    \/      |");
            Console.WriteLine(@"");
            Console.WriteLine(@"                      ______________________________________");
            Console.WriteLine(@"                     /   _______________________________    \");
            Console.WriteLine(@"                    |   |            __ __              |   |");
            Console.WriteLine(@"                    | _ |    /\     ) _) /''''',        |   |");
            Console.WriteLine(@"                    |(.)|   <  >    \ ) // '  `,        |   |");
            Console.WriteLine(@"                    | ` |    \/       \/// ~ |~:    +   |   |");
            Console.WriteLine(@"                    |   |             ///*\  ' :    |   |   |");
            Console.WriteLine(@"                    |   |            ///***\_~.'    |   |   |");
            Console.WriteLine(@"                    |   |  .'.    __///````,,..\_   |   |   |");
            Console.WriteLine(@"                    |   |   ` \ _/* +_\#\\~\ooo/ \  |   |   |");
            Console.WriteLine(@"                    |   |     |/:\ + *\_\#\~\so/!!\ |   |   |");
            Console.WriteLine(@"                    |   |    _\_::\ * + \-\#\\o/!!!\|   |   |");
            Console.WriteLine(@"                    |   |   / <_=:|           |_!!!_|   |   |");
            Console.WriteLine(@"                    |   |  <__/___| BLACKJACK |___ _|   |   |");
            Console.WriteLine(@"                    |   |   |_   _|           | ._/  >  |   |");
            Console.WriteLine(@"                    |   |   | !!! @     /* + \::=_>_/   |   |");
            Console.WriteLine(@"                    |   |   |\!!!/o\\#\_\ + * \::_\     |   |");
            Console.WriteLine(@"                    |   |   | \!!/os\~\#_\_* + \:/|     |   |");
            Console.WriteLine(@"                    |   |   |  \_/ooo\~\\#_\+_*/- \     |   |");
            Console.WriteLine(@"                    |   |   |    \''``,,,,///      .`.  |   |");
            Console.WriteLine(@"                    |   |   |     ,.- ***///        '   |   |");
            Console.WriteLine(@"                    |   |   |    : ~  \*///             |   |");
            Console.WriteLine(@"                    |   |   +    : |   \//\             |   |");
            Console.WriteLine(@"                    |   |        ,~  ~ //_( \     /\    | ; |");
            Console.WriteLine(@"                    |   |        ,'  ` /_(__(    <  >   |(_)|");
            Console.WriteLine(@"                    |   |         `````           \/    |   |");
            Console.WriteLine(@"                    |   |_______________________________|   |");
            Console.WriteLine(@"                     \______________________________________/");
            Console.WriteLine(@"");
            Console.WriteLine(@"");
            Console.WriteLine(@"");
            Console.WriteLine(@"");
        }
    }
}
