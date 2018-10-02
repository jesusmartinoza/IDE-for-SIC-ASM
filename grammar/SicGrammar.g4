grammar SicGrammar;


options {							
    language= CSharp2;
}


/*
 * Parser Rules
 */

programa: inicio (proposicion)+  fin;
inicio: ID SEP 'START' SEP NUM FINL;
fin: SEP 'END' (SEP ID)? FINL?;
proposicion: (instruccion | directiva | RSUB) FINL;
instruccion: ID? SEP INSTRUCCIONES SEP opinstruccion;
directiva: ID? SEP ('BYTE' SEP BYTEOP | (TIPODIRECTIVA SEP NUM));
opinstruccion: ID (',' ' '* 'X')?;
RSUB: ((ID SEP) | SEP)? 'RSUB' SEP?;

/*
 * Lexer Rules
 */


INSTRUCCIONES :('ADD'|'AND'|'COMP'|'DIV'|'J'| 'JLT' | 'JGT'|'JEQ'|'JSUB'|'LDA'|'LDCH'|'LDL'|'LDX'|'MUL'|'OR'|'RD'|'STA'|'STCH'|'STL'|'STSW'|'STX'|'SUB'|'TD' | 'TIX' | 'WD');
TIPODIRECTIVA: ('WORD'|'RESB'|'RESW');
BYTEOP : ('C\'' ID '\'' | 'X\'' NUMH '\'');
NUM : ('0'..'9' | ('A' .. 'F'))+ ('h' | 'H')?;	
//OPDIRECTIVA: NUMD | NUMH;
FINL: '\n';
NUMH: ('0'..'9' | ('A' .. 'F'))+;
NUMHH : NUMH ('h' | 'H' );
ID : ('a'..'z'|'A'..'Z')+;
SEP:(' ' |'\t')+; 
//END: 'END';