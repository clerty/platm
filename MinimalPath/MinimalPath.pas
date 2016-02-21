type
  tTable = array [1..20, 1..20] of integer;

var
  table, weight: tTable;
  n, m: integer;

procedure ReadTable(var t: tTable);
  var
    f: text;
    i, j: integer;
    a: char;
  
  Begin
    assign(f, 'INPUT.TXT');
    reset(f);
    read(f, n);
    read(f, a);
    read(f, m);
    readln(f);
    for i := 1 to n do
      begin
        for j := 1 to m do
          begin
            read(f, t[i, j]);
            if not eoln(f) then read(f, a);
          end;
        if not eof(f) then readln(f);
      end;
    close(f);
  End;

function min(a: integer; b: integer): integer;
  Begin
    if a<=b then min := a
            else min := b;
  End;

function W(i: integer; j: integer): integer;
  Begin
    if      (i=1) and (j=1) then W := table[i, j]
    else if i=1             then W := W(i, j-1) + table[i, j]
    else if j=1             then W := W(i-1, j) + table[i, j]
                            else W := min(W(i-1, j), W(i, j-1)) + table[i, j];
  End;

procedure CalculateWays(t: tTable; var w: tTable);
  var
    i, j: integer;
  
  Begin
    for i := 1 to n do
      for j := 1 to m do
        if      (i=1) and (j=1) then w[i, j] := table[i, j]
        else if i=1             then w[i, j] := w[i, j-1] + table[i, j]
        else if j=1             then w[i, j] := w[i-1, j] + table[i, j]
                                else w[i, j] := min(w[i-1, j], w[i, j-1]) + table[i, j];
  End;

procedure OutputValue(v: integer);
  var
    f: text;
  
  Begin
    assign(f, 'OUTPUT.TXT');
    rewrite(f);
    write(f, v);
    close(f);
  End;

begin
  ReadTable(table);
  CalculateWays(table, weight);
  OutputValue(weight[n, m]);
end.
