COPIATEST   START   28h
            SIO
            SHIFTL   X,1
FIRST       +LDX     ZERO
MOVECH      LDCH    STRA, X
            STCH    STRB, X
            TIX     TAM
            JLT     MOVECH
STRA        BYTE    C'probando'
STRB        RESB    1
ZERO        WORD    0
TAM         WORD    8
    END FIRST