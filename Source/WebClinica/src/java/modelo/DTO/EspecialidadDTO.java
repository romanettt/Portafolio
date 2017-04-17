/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package modelo.DTO;

/**
 *
 * @author Willywes
 */
public class EspecialidadDTO {
    
    private int id;
    private String nombre;

    public EspecialidadDTO() {
    }
    

    public EspecialidadDTO(int id, String nombre) {
        this.id = id;
        this.nombre = nombre;
    }

    public int getId() {
        return id;
    }

    public String getNombre() {
        return nombre;
    }
    
    
}
