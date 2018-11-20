COPIATEST   START   28h
FIRST       LDX     ZERO
MOVECH      LDCH    STRA, X
            STCH    STRB, X
            TIX     TAM
            JLT     MOVECH
STRA        BYTE    C'probando'
STRB        RESB    8
ZERO        WORD    0
TAM         WORD    8
    END FIRST