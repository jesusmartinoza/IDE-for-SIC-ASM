SUM START   0H
FIRST   LDX #0
    LDA #0
    +LDB    #TABLEUNO
    BASE    TABLEDOS
LOOP    ADD TABLEUNO,X
    ADD TABLEDOS,X
    TIX COUNT
    JLT LOOP
    RMO A, X
    SHIFTR  A,2h
    +STA    TOTAL
    CLEAR   X
COUNT   RESW    1
TABLEUNO  RESW    2000
TABLEDOS  RESW    2000
TOTAL   RESW    2000
    END FIRST