-- ESPECIALIDAD

-- CREAR
CREATE OR REPLACE FUNCTION create_especialidad(v_nombre ESPECIALIDAD.NOMBRE%TYPE) 
RETURN NUMBER AS

flag NUMBER := 0;

BEGIN    
    INSERT INTO ESPECIALIDAD VALUES(SEQ_ESPECIALIDAD.NEXTVAL,UPPER(v_nombre));
    flag := 1;
    return flag;

EXCEPTION 
    WHEN others THEN
    RETURN flag;
END;

-- UPDATE
CREATE OR REPLACE FUNCTION update_especialidad(v_id_esp ESPECIALIDAD.ID_ESP%TYPE, v_nombre ESPECIALIDAD.NOMBRE%TYPE) 
RETURN NUMBER AS

flag NUMBER := 0;

BEGIN
    UPDATE ESPECIALIDAD
    SET NOMBRE = UPPER(v_nombre)
    WHERE ID_ESP = v_id_esp;
    flag := 1;
    return flag;

EXCEPTION 
    WHEN others THEN
    RETURN flag;
END;

-- DELETE
CREATE OR REPLACE FUNCTION delete_especialidad(v_id_esp ESPECIALIDAD.ID_ESP%TYPE) 
RETURN NUMBER AS

flag NUMBER := 0;

BEGIN
    DELETE FROM ESPECIALIDAD
    WHERE ID_ESP = v_id_esp;
    flag := 1;
    return flag;

EXCEPTION 
    WHEN others THEN
    RETURN flag;
END;

-- READ
CREATE OR REPLACE FUNCTION read_especialidad(v_id_esp ESPECIALIDAD.ID_ESP%TYPE) 
RETURN NUMBER AS

flag NUMBER := 0;

BEGIN
    SELECT * FROM ESPECIALIDAD
    WHERE ID_ESP = v_id_esp;
    flag := 1;
    return flag;

EXCEPTION 
    WHEN others THEN
    RETURN flag;
END;

