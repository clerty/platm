program polinom4ik;
  uses
    myList;
  
  const
    k = 5;
  
  type
    tLength = 1..k;
    tArray = array [1..2, tLength] of real;
  
  var
    polinom: tList;
    i: tLength;
    outputArray: tArray;
  
  procedure polinomToArray(var pol: tList; var arr: tArray; var l: tLength);
  Begin
    if not eol(pol) then
      begin
        arr[1, l] := getCurr(pol).coef;
        arr[2, l] := getCurr(pol).exp;
        next(pol);
        if not eol(pol) then inc(l);
        polinomToArray(pol, arr, l); 
      end;
  End;
  
  procedure setPolinom(var list: tList);
    var
      element: tValue;
      n: tLength;
  
  Begin
    createList(list);
    for n := 1 to k do
      begin
  	    element.coef := random(50);
  	    element.exp := random(10);
  	    addLast(list, initElem(element));
      end;
    printList(list);
    writeln;
    reset(list);
  End;
  
  procedure printArray(var arr: tArray);
    var
      i: 1..2;
      n: tLength;
  
  Begin
    for i := 1 to 2 do
      begin
        for n := 1 to k do write(arr[i, n], ' ');
        writeln;
      end;
  End;

BEGIN
  setPolinom(polinom);
  
  i := 1;
  polinomToArray(polinom, outputArray, i);
  
  printArray(outputArray);
END.
