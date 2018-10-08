COPY    START   1000h
FIRST   STL RETADR
CLOOP   JSUB    RDREC
    LD LENGTH
    COMP    ZERO
    JEQ ENDFIL
    JSUB    WRREC
    J   CLOOP
ENDFIL  LDA EOF
    STA BUFFER
    BYTE    X'123'
    LDA THREE
    STA LENGTH
    JSUB    WRREC
    LDL RETADR
    RSUB
EOF BYTE    C'11'
EOF BYTE    C'EOF'
THREE   WORD    3
ZERO    WORD    0
RETADR  RESW    1
LENGTH  RESW    1
HOLA    BYTE    X123'
OTRO    BYTE    'ASD'
BUFFER  RESB    4096
RDREC   LDX ZERO
    LDA ZERO
RLOOP   TD  INPUT
    JEQ RLOOP
    RD  INPUT
    COMP    ZERO
    JEQ EXIT
    STCH    BUFFER,X
    TIX MAXLEN
    JLT RLOOP
EXIT    STX LENGTH
    RSUB
INPUT   BYTE    X'F1'
MAXLEN  WORD    4096

WRREC   LDX ZERO
WLOOP   TD  OUTPUT
    JEQ WLOOP
    LDCH    BUFFER, X
    WD  OUTPUT
    TIX LENGTH
    JLT WLOOP
    RSUB
FOO BYTE    X'05'
    END FIRST