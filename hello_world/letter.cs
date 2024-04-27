public class Letter
{
    private List<string> letterA = new List<string>{"     A     ","    A A    ","   A   A   ","  AAAAAAA  "," A       A ",};
    private List<string> letterB = new List<string>{" BBBBB  "," B    B "," BBBBB  "," B    B "," BBBBB  ",};
    private List<string> letterC = new List<string>{"  CCCCC  "," C     C "," C       "," C     C ","  CCCCC  "};
    private List<string> letterD = new List<string>{" DDDDD   "," D    D  "," D     D "," D    D  "," DDDDD   "};
    private List<string> letterE = new List<string>{" EEEEE "," E     "," EEEE  "," E     "," EEEEE "};
    private List<string> letterF = new List<string>{" FFFFF "," F     "," FFFF  "," F     "," F     "};
    private List<string> letterG = new List<string>{"  GGGG "," G     "," G  GG "," G   G ","  GGGG "};
    private List<string> letterH = new List<string>{" H   H "," H   H "," HHHHH "," H   H "," H   H "};
    private List<string> letterI = new List<string>{" III ","  I  ","  I  ","  I  "," III "};
    private List<string> letterJ = new List<string>{"    J ","    J ","    J "," J  J ","  JJ  "};
    private List<string> letterK = new List<string>{" K  K  "," K K   "," KK    "," K K   "," K  K  "};
    private List<string> letterL = new List<string>{" L     "," L     "," L     "," L     "," LLLLL "};
    private List<string> letterM = new List<string>{" M   M "," MM MM "," M M M "," M   M "," M   M "};
    private List<string> letterN = new List<string>{" N   N "," NN  N "," N N N "," N  NN "," N   N "};
    private List<string> letterO = new List<string>{"  OOO  "," O   O "," O   O "," O   O ","  OOO  "};
    private List<string> letterP = new List<string>{" PPPP  "," P   P "," PPPP  "," P     "," P     "};
    private List<string> letterQ = new List<string>{"  QQQ   "," Q   Q  "," Q   Q  "," Q  QQ  ","  QQQ Q "};
    private List<string> letterR = new List<string>{" RRRRR  "," R    R "," RRRRR  "," R   R  "," R    R "};
    private List<string> letterS = new List<string>{"  SSSS "," S     ","  SSS  ","     S "," SSSS  "};
    private List<string> letterT = new List<string>{" TTTTT ","   T   ","   T   ","   T   ","   T   "};
    private List<string> letterU = new List<string>{" U   U "," U   U "," U   U "," U   U ","  UUU  "};
    private List<string> letterV = new List<string>{" V   V "," V   V "," V   V ","  V V  ","   V   "};
    private List<string> letterW = new List<string>{" W   W "," W   W "," W W W "," W W W ","  W W  "};
    private List<string> letterX = new List<string>{" X   X ","  X X  ","   X   ","  X X  "," X   X "};
    private List<string> letterY = new List<string>{" Y   Y ","  Y Y  ","   Y   ","   Y   ","   Y   "};
    private List<string> letterZ = new List<string>{" ZZZZZ ","    Z  ","   Z   ","  Z    "," ZZZZZ "};
    private List<string> letterSpace = new List<string>{"         ","         ","         ","         ","         "};


    public void PrintLine (string line){
        string[] newline = GetLetter(line);
        foreach (string l in newline){
            Console.WriteLine(l);
        }
    }

    public string[] GetLetter(string line){

        line = line.ToUpper();
        string[] words = new string[5];

        for (int index = 0; index < 5; index++)
        {
            words[index] = "";
            foreach (char letter in line)
            {
                switch (letter)
                {
                    case 'A': words[index] += letterA[index]; break;
                    case 'B': words[index] += letterB[index]; break;
                    case 'C': words[index] += letterC[index]; break;
                    case 'D': words[index] += letterD[index]; break;
                    case 'E': words[index] += letterE[index]; break;
                    case 'F': words[index] += letterF[index]; break;
                    case 'G': words[index] += letterG[index]; break;
                    case 'H': words[index] += letterH[index]; break;
                    case 'I': words[index] += letterI[index]; break;
                    case 'J': words[index] += letterJ[index]; break;
                    case 'K': words[index] += letterK[index]; break;
                    case 'L': words[index] += letterL[index]; break;
                    case 'M': words[index] += letterM[index]; break;
                    case 'N': words[index] += letterN[index]; break;
                    case 'O': words[index] += letterO[index]; break;
                    case 'P': words[index] += letterP[index]; break;
                    case 'Q': words[index] += letterQ[index]; break;
                    case 'R': words[index] += letterR[index]; break;
                    case 'S': words[index] += letterS[index]; break;
                    case 'T': words[index] += letterT[index]; break;
                    case 'U': words[index] += letterU[index]; break;
                    case 'V': words[index] += letterV[index]; break;
                    case 'W': words[index] += letterW[index]; break;
                    case 'X': words[index] += letterX[index]; break;
                    case 'Y': words[index] += letterY[index]; break;
                    case 'Z': words[index] += letterZ[index]; break;
                    default: words[index] += letterSpace[index]; break;
                }
            }
        }
        return words;
    }
}