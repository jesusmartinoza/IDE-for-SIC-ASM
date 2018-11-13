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
instruccion: ID? SEP (formatuno | formatdos | ('+'? formatres));
formatuno: INSTRUNO;
formatdos: (INSFDOSRR SEP REG SEP ',' SEP REG) | (INSFDOSRN SEP REG SEP ',' SEP NUM) | ('SVC' SEP REG SEP ',' SEP NUM) | (INSFDOSR SEP REG SEP ',' SEP NUM);
formatres: INSTRES SEP MODIR? ID INDEX?;
RSUB: ((ID SEP) | SEP)? 'RSUB' SEP?;
directiva: ID? SEP ('BYTE' SEP BYTEOP | (TIPODIRECTIVA SEP NUM));

/*
 * Lexer Rules
 */


TIPODIRECTIVA: ('WORD'|'RESB'|'RESW');
BYTEOP : ('C\'' ID '\'' | 'X\'' NUMH '\'');
NUM : ('0'..'9' | ('A' .. 'F'))+ ('h' | 'H')?;	
FINL: '\n';
NUMH: ('0'..'9' | ('A' .. 'F'))+;
NUMHH : NUMH ('h' | 'H' );
ID : ('a'..'z'|'A'..'Z')+;
INDEX : (',' ' '* 'X');
SEP:(' ' |'\t')+; 
INSTRUNO: 'FIX' | 'FLOAT' | 'HIO' | 'NORM' | 'SIO' | 'TIO'; 
INSFDOSRN: 'SHIFTR' | 'SHIFTL';
INSFDOSR: 'CLEAR' | 'TIXR';
INSFDOSRR: 'ADDR' | 'COMPR' | 'DIVR' | 'MULR' | 'RMO' | 'SUBR';
INSTRES:('ADD'|'ADDF'|'AND'|'COMP'|'COMPF'|'DIV'|'DIVF'|'J'|'JEQ'|'JGT'|'JLT'|'JSUB'|'LDA'|'LDB'|'LDCH'|'LDF'|'LDL'|'LDS'|'LDT'|'LDX'|'LPS'|'MUL'|'MULF'|'OR'|'RD'|'SSK'|'STA'|'STB'|'STCH'|'STF'|'STI'|'STL'|'STS'|'STSW'|'STT'|'STX'|'SUB'|'SUBF'|'TD'|'TIX'|'WD');
REG: 'A'|'X'|'L'|'B'|'S'|'T'|'F';
MODIR: '#' | '@';