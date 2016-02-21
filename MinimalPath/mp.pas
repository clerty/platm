type
  tTable = array [1..20, 1..20] of integer;

var
  table, weights: tTable;
  n, m: integer;

procedure ReadTable(var t: tTable);
  var
    i, j: integer;
  
  Begin
    assign(input, 'INPUT.TXT');
    reset(input);
    read(n);
    read(m);
    for i := 1 to n do
        for j := 1 to m do
            read(t[i, j]);
    close(input);
  End;

function min(a: integer; b: integer): integer;
  Begin
    if a<=b then min := a
            else min := b;
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

begin
  ReadTable(table);
  CalculateWays(table, weights);
  assign(output, 'OUTPUT.TXT');
  rewrite(output);
  write(weights[n, m]);
  close(output);
end.
