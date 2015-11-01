unit myList;
interface
  type
    tValue = record
							coef: real;
							exp: integer;
						 end;
	
  const
    zeroValue : tValue = (coef: 0; exp: 0);
	
	type
    pPointer = ^tElement;
    tElement = record
                value: tValue;
                next: pPointer;
               end;
    tList = record
              pFirst, pLast, pCurr: pPointer;
              size: cardinal;
            end;
  
  procedure createList(var list: tList);
  procedure eraseList(var list: tList);
  procedure destroyList(var list: tList);
  
  function initElem(val: tValue): pPointer;
  procedure addFirst(var list: tList; elem: pPointer);
  procedure addAfterCurr(var list: tList; elem: pPointer);
  procedure addLast(var list: tList; elem: pPointer);
  procedure deleteCurr(var list: tList);
  
  procedure reset(var list: tList);
  
  procedure prev(var list: tList);
  procedure next(var list: tList);
  
  function getCurr(list: tList): tValue;
  function eol(list: tList): boolean;
  function isEmptyList(list: tList): boolean;
  procedure printList(list: tList);

implementation
  procedure createList;
    var
      p: pPointer;
    
  Begin
    new(p);
    p^.value := zeroValue;
    p^.next := nil;
    list.pFirst := p;
    list.pLast := p;
    list.size := 0;
    reset(list);
  End;
  
  procedure eraseList;
  Begin
    reset(list);
    while not isEmptyList(list) do
      begin
        deleteCurr(list);
        next(list);
      end;
    list.pLast := list.pFirst;
  End;
  
  procedure destroyList;
  Begin
    eraseList(list);
    dispose(list.pFirst);
    dispose(list.pLast);
  End;
  
  
  function initElem: pPointer;
    var
      p: pPointer;
    
  Begin
    new(p);
    p^.value := val;
    p^.next := nil;
    result := p;
  End;
  
  procedure addFirst;
  Begin
    elem^.next := list.pFirst^.next;
    list.pFirst^.next := elem;
    inc(list.size);
  End;
  
  procedure addAfterCurr;
  Begin
    elem^.next := list.pCurr^.next;
    list.pCurr^.next := elem;
    inc(list.size);
  End;
  
  procedure addLast;
  Begin
    list.pLast^.next := elem;
    list.pLast := elem;
    inc(list.size);
  End;
  
  procedure deleteCurr;
    var
      p: pPointer;
  
  Begin
    prev(list);
    p := list.pCurr^.next^.next;
    dispose(list.pCurr^.next);
    list.pCurr^.next := p;
    dec(list.size);
  End;
  
  
  procedure reset;
  Begin
    list.pCurr := list.pFirst^.next;
  End;
  
  function getCurr: tValue;
  Begin
    result := list.pCurr^.value;
  End;
  
  
  procedure prev;
    var
      p: pPointer;
  Begin
    p := list.pCurr;
    list.pCurr := list.pFirst;
    while list.pCurr^.next <> p do next(list);
  End;
  
  procedure next;
  Begin
    list.pCurr := list.pCurr^.next;
  End;
  
  
  function eol: boolean;
  Begin
    result := list.pCurr = nil;
  End;
  
  function isEmptyList: boolean;
  Begin
    result := list.size = 0;
  End;
  
  procedure printList;
  Begin
    reset(list);
    while not eol(list) do
      begin
        write(getCurr(list), ' ');
        next(list);
      end;
  End;

END.