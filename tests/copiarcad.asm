COPIACADENA START   28H         
            LDX     ZERO        
MOVECH      LDCH    STRA, X      
            STCH    STRB, X      
            TIX     TAM      
            JLT     MOVECH  
STRA        BYTE    C'Probando2015'
STRB        RESB    11          
ZERO        WORD    0           
TAM         WORD    12          
            END 