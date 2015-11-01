  type
    tAlphabet = string;
    tWord = string;
    tDictionary = text;
  
  var
    dictionary: tDictionary;
    alphabet: tAlphabet;
  
  procedure getWord(var w: tWord; var d: tDictionary);
  Begin
    if not eof(d) then readln(d, w);
  End;
  
  procedure outputWord(var w: tWord);
  Begin
    writeln(w);
  End;
  
  function belongs(var elem: char; var str: tAlphabet): boolean;
    var
      j: cardinal;
      b: boolean;
  
  Begin
    b := false;
    j := 1;
    while (j<=length(str)) and not b do
      begin
        b := elem = str[j];
        inc(j);
      end;
    result := b;
  End;
  
  procedure exclude(var str: tAlphabet; elem: char);
    var
      j: cardinal;
      b: boolean;
  
  Begin
    b := false;
    j := 1;
    while (j<=length(str)) and not b do
      begin
        if elem = str[j] then
          begin
            str[j] := ' ';
            b := true;
          end;
        inc(j);
      end;
  End;
  
  function isAcceptable(var w: tWord; a: tAlphabet): boolean;
    var
      i: cardinal;
      found: boolean;
  
  Begin
    found := false;
    i := 1;
    while (i<=length(w)) and not found do
      begin
        if belongs(w[i], a) then exclude(a, w[i])
                     else found := true;
        inc(i);
      end;
    result := not found;
  End;
  
  procedure find(abc: tAlphabet; var dict: tDictionary);
    var
      currWord: tWord;
  
  Begin
    getWord(currWord, dict);
    while not eof(dict) do
      begin
        if isAcceptable(currWord, abc) then outputWord(currWord);
        getWord(currWord, dict);
      end;
  End;
  
BEGIN
  assign(dictionary, 'zdf-win.txt');
  reset(dictionary);
  
  alphabet := 'ןגכאהנûןגאמכ';
  
  find(alphabet, dictionary);
  
  close(dictionary);
END.