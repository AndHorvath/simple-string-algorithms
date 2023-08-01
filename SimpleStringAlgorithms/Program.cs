using System.Text;

/*
A) számjegyek cseréje úgy, hogy az eredeti számhoz adva 9-et kapjunk (pl. 1 -> 8; 5 -> 4; 0 -> 9; ...)
B) ó, ió, ció, áció
C) minden magánhangzó megduplázása
D) magánhangzók cseréje * karakterre
E) tetszőleges szövegrészlet kivágása (x helytől y hosszon) saját eljárással, hibás x és y esetén hibaüzenettel
F) szöveg titkosítása: minden karakterhez hozzá adunk ASCII szerint x értéket (x = 1 esetén a helyett b, b helyett c stb.)
G) minden 2. és 3. betű új szövegbe
H) szóközök kicserélés _ jelre
I) minden karakter megkettőzése: abc -> aabbcc
J) minden 3. és 5. betű cseréje *-ra
K) kisbetűből nagybetű és nagybetűből kisbetű (pl. AbC -> aBc)
L) hullámos szöveg (pl. alma -> AlMa)
M) páros és páratlan betűk cseréje (abcd -> badc)
N) minden számjegy megduplázása
O) magánhangzók cseréje nagybetűsre (pl. abcde -> AbcdE)
P) ékezettelenítő (á -> a; ö, ő -> o)
Q) számok cseréje betűre: 1 -> a, 2 -> b stb.
R) magánhangzók megszámlálása (angol abc)
S) szöveg visszafelé
T) minden mássalhangzó megduplázása
U) számok kiválogatása szövegből (pl. a1b2c3 -> 123)
*/



// ----------------------------------------------------------------------------
// --- A) számjegyek cseréje úgy, hogy az eredeti számhoz adva 9-et kapjunk ---
// ----------------------------------------------------------------------------

string stringA = "apple4tree7thing987";

MethodA(stringA);
CreateSeparator();

static void MethodA(string pString)
{
    Console.WriteLine(pString);
    for (int i = 0; i < pString.Length; i++)
    {
        if (int.TryParse(pString[i].ToString(), out int j))
        {
            Console.Write(9 - j);
        }
        else
        {
            Console.Write(pString[i]);
        }
    }
}



// ----------------------------------------------------------------------------
// --- B) ó, ió, ció, áció ----------------------------------------------------
// ----------------------------------------------------------------------------

string stringB = "Vakáció";

MethodB(stringB);
CreateSeparator();

static void MethodB(string pString)
{
    StringBuilder closingSubstring = new();

    Console.WriteLine(pString);
    for (int i = pString.Length - 1; i >= 0; i--)
    {
        if (i != 0)
        {
            Console.WriteLine(closingSubstring.Insert(0, pString[i]));
        }
        else
        {
            Console.Write(closingSubstring.Insert(0, pString[i]));
        }
    }
}



// ----------------------------------------------------------------------------
// --- C) minden magánhangzó megduplázása -------------------------------------
// ----------------------------------------------------------------------------

string stringC = "A simple solution to append a character to a string is using the + operator.";

MethodC(stringC);
CreateSeparator();

static void MethodC(string pString)
{
    char[] vowels = CreateVowelArray();

    Console.WriteLine(pString);
    for (int i = 0; i < pString.Length; i++)
    {
        if (IsContainedIgnoreCase(vowels, pString[i]))
        {
            Console.Write(pString[i].ToString() + pString[i].ToString());
        }
        else
        {
            Console.Write(pString[i]);
        }
    }
}



// ----------------------------------------------------------------------------
// --- D) magánhangzók cseréje * karakterre -----------------------------------
// ----------------------------------------------------------------------------

string stringD = "A vowel is a sound, such as the English ah, produced with an open vocal tract.";

MethodD(stringD);
CreateSeparator();

static void MethodD(string pString)
{
    char[] vowels = CreateVowelArray();

    Console.WriteLine(pString);
    for (int i = 0; i < pString.Length; i++)
    {
        if (IsContainedIgnoreCase(vowels, pString[i]))
        {
            Console.Write('*');
        }
        else
        {
            Console.Write(pString[i]);
        }
    }
}



// ----------------------------------------------------------------------------
// --- E) tetszőleges szövegrészlet kivágása (x helytől y hosszon) ------------
// ----------------------------------------------------------------------------

string stringE = "The word text has its origins in Quintilian's Institutio Oratoria.";
int fromPositionE = 10;
int toPositionE = 40;

MethodE(stringE, fromPositionE, toPositionE);
CreateSeparator();

static void MethodE(string pString, int pFromPosition, int pToPosition)
{
    StringBuilder subString = new();
    int fromIndex = pFromPosition - 1;
    int toIndex = pToPosition - 1;

    Console.WriteLine(pString);
    for (int i = fromIndex; i <= toIndex; i++)
    {
        subString.Append(pString[i]);
    }
    Console.Write(subString);
}



// ----------------------------------------------------------------------------
// --- F) szöveg titkosítva: minden karakterhez ASCII szerint x értéket adunk -
// ----------------------------------------------------------------------------

string stringF = "SecretABC";
int translationF = 3;

MethodF(stringF, translationF);
CreateSeparator();

static void MethodF(string pString, int pTranslation)
{
    Console.WriteLine(pString);
    for (int i = 0; i < pString.Length; i++)
    {
        Console.Write((char)(pString[i] + pTranslation));
    }
}



// ----------------------------------------------------------------------------
// --- G) minden 2. és 3. betű új szövegbe ------------------------------------
// ----------------------------------------------------------------------------

string stringG = "The word text has its origins in Quintilian's Institutio Oratoria.";

MethodG(stringG);
CreateSeparator();

static void MethodG(string pString)
{
    StringBuilder newString = new();
    int counter;

    Console.WriteLine(pString);
    for (int i = 0; i < pString.Length; i++)
    {
        counter = i + 1;
        if (counter % 2 == 0 || counter % 3 == 0)
        {
            newString.Append(pString[i]);
        }
    }
    Console.Write(newString);
}



// ----------------------------------------------------------------------------
// --- H) szóközök kicserélése _ jelre ----------------------------------------
// ----------------------------------------------------------------------------

string stringH = "English uses spaces to separate words, but not all languages follow this.";

MethodH(stringH);
CreateSeparator();

static void MethodH(string pString)
{
    Console.WriteLine(pString);
    for (int i = 0; i < pString.Length; i++)
    {
        if (char.IsWhiteSpace(pString[i]))
        {
            Console.Write('_');
        }
        else
        {
            Console.Write(pString[i]);
        }
    }
}



// ----------------------------------------------------------------------------
// --- I) minden karakter megkettőzése: abc -> aabbcc -------------------------
// ----------------------------------------------------------------------------

string stringI = "abc";

MethodI(stringI);
CreateSeparator();

static void MethodI(string pString)
{
    Console.WriteLine(pString);
    for (int i = 0; i < pString.Length; i++)
    {
        Console.Write(pString[i].ToString() + pString[i].ToString());
    }
}



// ----------------------------------------------------------------------------
// --- J) minden 3. és 5. betű cseréje *-ra -----------------------------------
// ----------------------------------------------------------------------------

string stringJ = "abcabcabcabcdefabcdef";

MethodJ(stringJ);
CreateSeparator();

static void MethodJ(string pString)
{
    int counter;

    Console.WriteLine(pString);
    for (int i = 0; i < pString.Length; i++)
    {
        counter = i + 1;
        if (counter % 3 == 0 || counter % 5 == 0)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(pString[i]);
        }
    }
}



// ----------------------------------------------------------------------------
// --- K) kisbetűből nagybetű és nagybetűből kisbetű (pl. AbC -> aBc) ---------
// ----------------------------------------------------------------------------

string stringK = "AbC";

MethodK(stringK);
CreateSeparator();

static void MethodK(string pString)
{
    Console.WriteLine(pString);
    for (int i = 0; i < pString.Length; i++)
    {
        if (char.IsLower(pString[i]))
        {
            Console.Write(char.ToUpper(pString[i]));
        }
        else if (char.IsUpper(pString[i]))
        {
            Console.Write(char.ToLower(pString[i]));
        }
        else
        {
            Console.Write(pString[i]);
        }
    }
}



// ----------------------------------------------------------------------------
// --- L) hullámos szöveg (pl. alma -> AlMa) ----------------------------------
// ----------------------------------------------------------------------------

string stringLA = "This is the entry line.";
string stringLB = "thisistheentrylinewithoutwhitespacesandinterpunction";

MethodL(stringLA);
CreateSeparator();

MethodL(stringLB);
CreateSeparator();

static void MethodL(string pString)
{
    Console.WriteLine(pString);
    for (int i = 0; i < pString.Length; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write(char.ToUpper(pString[i]));
        }
        else
        {
            Console.Write(pString[i]);
        }
    }
}



// ----------------------------------------------------------------------------
// --- M) páros és páratlan betűk cseréje (abcd -> badc) ----------------------
// ----------------------------------------------------------------------------

string stringM = "Abcdefg, hi jkl, mn - opqrst -, u vw x yz.";

MethodM(stringM);
CreateSeparator();

static void MethodM(string pString)
{
    char[] characterArray = pString.ToCharArray();
    List<int> letterIndices = new();
    int letterCounter;

    Console.WriteLine(pString);
    for (int i = 0; i < pString.Length; i++)
    {
        if (char.IsLetter(pString[i]))
        {
            letterIndices.Add(i);
        }
    }
    for (int j = 0; j < letterIndices.Count; j++)
    {
        letterCounter = j + 1;
        if (letterCounter % 2 == 0)
        {
            SwapElementsByIndices(characterArray, letterIndices[j], letterIndices[j - 1]);
        }
    }
    Console.Write(new string(characterArray));
}



// ----------------------------------------------------------------------------
// --- N) minden számjegy megduplázása ----------------------------------------
// ----------------------------------------------------------------------------

string stringN = "apple4tree7thing987";

MethodN(stringN);
CreateSeparator();

static void MethodN(string pString)
{
    char[] characterArray = pString.ToCharArray();

    Console.WriteLine(pString);
    for (int i = 0; i < pString.Length; i++)
    {
        if (char.IsDigit(pString[i]))
        {
            Console.Write(int.Parse(pString[i].ToString()) * 2);
        }
        else
        {
            Console.Write(pString[i]);
        }
    }
}



// ----------------------------------------------------------------------------
// --- O) magánhangzók cseréje nagybetűsre (pl. abcde -> AbcdE) ---------------
// ----------------------------------------------------------------------------

string stringO = "abcde";

MethodO(stringO);
CreateSeparator();

static void MethodO(string pString)
{
    char[] vowels = CreateVowelArray();

    Console.WriteLine(pString);
    for (int i = 0; i < pString.Length; i++)
    {
        if (Array.IndexOf(vowels, pString[i]) > - 1)
        {
            Console.Write(char.ToUpper(pString[i]));
        }
        else
        {
            Console.Write(pString[i]);
        }
    }
}



// ----------------------------------------------------------------------------
// --- P) ékezettelenítő (á -> a; ö, ő -> o) ----------------------------------
// ----------------------------------------------------------------------------

string stringP = "Az ÁRVÍZTŰRŐ TÜKÖRFÚRÓGÉP szókapcsolatban az összes ékezetes magyar betű előfordul.";

MethodP(stringP);
CreateSeparator();

static void MethodP(string pString)
{
    char[] characterArray = pString.ToCharArray();
    Dictionary<char, char[]> accentedVowelsToVowels = CreateAccentedVowelsToVowels();
    
    Console.WriteLine(pString);
    for (int i = 0; i < pString.Length; i++)
    {
        foreach (char vowel in accentedVowelsToVowels.Keys)
        {
            if (IsContainedIgnoreCase(accentedVowelsToVowels[vowel], pString[i]))
            {
                characterArray[i] = char.IsLower(pString[i]) ? vowel : char.ToUpper(vowel);
                break;
            }
        }
    }
    Console.Write(new string(characterArray));
}



// ----------------------------------------------------------------------------
// --- Q) számok cseréje betűre: 1 -> a, 2 -> b stb. --------------------------
// ----------------------------------------------------------------------------

string stringQ = "apple4tree7thing986apple3tree5thing210";

MethodQ(stringQ);
CreateSeparator();

static void MethodQ(string pString)
{
    int translation = 'a' - '1';
    int zeroCorrection;
    
    Console.WriteLine(pString);
    for (int i = 0; i < pString.Length; i++)
    {
        if (char.IsDigit(pString[i]))
        {
            zeroCorrection = pString[i] != '0' ? 0 : 10;
            Console.Write((char)(pString[i] + translation + zeroCorrection));
        }
        else
        {
            Console.Write(pString[i]);
        }
    }
}



// ----------------------------------------------------------------------------
// --- R) magánhangzók megszámlálása (angol abc) ------------------------------
// ----------------------------------------------------------------------------

string stringR = "A vowel is a sound, such as the English ah, produced with an open vocal tract.";

MethodR(stringR);
CreateSeparator();

static void MethodR(string pString)
{
    char[] vowels = CreateVowelArray();
    int numberOfVowels = 0;
    
    Console.WriteLine(pString);
    for (int i = 0; i < pString.Length; i++)
    {
        if (IsContainedIgnoreCase(vowels, pString[i]))
        {
            numberOfVowels++;
        }
    }
    Console.Write("Number of vowels: {0}", numberOfVowels);
}



// ----------------------------------------------------------------------------
// --- S) szöveg visszafelé ---------------------------------------------------
// ----------------------------------------------------------------------------

string stringS = "apple";

MethodS(stringS);
CreateSeparator();

static void MethodS(string pString)
{
    Console.WriteLine(pString);
    for (int i = pString.Length - 1; i >= 0; i--)
    {
        Console.Write(pString[i]);
    }
}



// ----------------------------------------------------------------------------
// --- T) minden mássalhangzó megduplázása ------------------------------------
// ----------------------------------------------------------------------------

string stringT = "A simple solution to append a character to a string is using the + operator.";

MethodT(stringT);
CreateSeparator();

static void MethodT(string pString)
{
    char[] vowels = CreateVowelArray();
    string modification;
    
    Console.WriteLine(pString);
    for (int i = 0; i < pString.Length; i++)
    {
        modification = string.Empty;
        if (char.IsLetter(pString[i]) && !IsContainedIgnoreCase(vowels, pString[i]))
        {
            modification += pString[i].ToString();
        }
        Console.Write(pString[i].ToString() + modification);
    }
}



// ----------------------------------------------------------------------------
// --- U) számok kiválogatása szövegből (pl. a1b2c3 -> 123) -------------------
// ----------------------------------------------------------------------------

string stringU = "apple4tree7thing986apple3tree5thing210";

MethodU(stringU);
CreateSeparator();

static void MethodU(string pString)
{
    Console.WriteLine(pString);
    for (int i = 0; i < pString.Length; i++)
    {
        if (char.IsDigit(pString[i]))
        {
            Console.Write(pString[i]);
        }
    }
}



// --- common methods ---------------------------------------------------------

static char[] CreateVowelArray()
{
    return new char[] { 'a', 'e', 'i', 'o', 'u' };
}

static Dictionary<char, char[]> CreateAccentedVowelsToVowels()
{
    return
        new()
        {
            { 'a', new char[] { 'á' } },
            { 'e', new char[] { 'é' } },
            { 'i', new char[] { 'í' } },
            { 'o', new char[] { 'ó', 'ö', 'ő' } },
            { 'u', new char[] { 'ú', 'ü', 'ű' } }
        };
}

static bool IsContainedIgnoreCase(char[] pCharacters, char pCharacter)
{
    return
        Array.IndexOf(pCharacters, pCharacter) > -1 ||
        Array.IndexOf(pCharacters, char.ToLower(pCharacter)) > -1;
}

static void SwapElementsByIndices(char[] pArray, int pFirstIndex, int pSecondIndex)
{
    (pArray[pFirstIndex], pArray[pSecondIndex]) = (pArray[pSecondIndex], pArray[pFirstIndex]);
}

static void CreateSeparator()
{
    Console.WriteLine();
    Console.WriteLine("-----");
}