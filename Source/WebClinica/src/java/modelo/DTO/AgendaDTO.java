/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package modelo.DTO;

import java.sql.Date;
import java.sql.Timestamp;


/**
 *
 * @author Romanet
 */
public class AgendaDTO {
    
    private int id;
    private Date fecha;
    private Timestamp horaInicio;    
    private Timestamp horaTermino;
    private MedicoDTO medicoDTO;  

    public AgendaDTO() {
        
    }

    public AgendaDTO(int id, Date fecha, Timestamp horaInicio, Timestamp horaTermino, MedicoDTO medicoDTO) {
        this.id = id;
        this.fecha = fecha;
        this.horaInicio = horaInicio;
        this.horaTermino = horaTermino;
        this.medicoDTO = medicoDTO;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public Date getFecha() {
        return fecha;
    }

    public void setFecha(Date fecha) {
        this.fecha = fecha;
    }

    public Timestamp getHoraInicio() {
        return horaInicio;
    }

    public void setHoraInicio(Timestamp horaInicio) {
        this.horaInicio = horaInicio;
    }

    public Timestamp getHoraTermino() {
        return horaTermino;
    }

    public void setHoraTermino(Timestamp horaTermino) {
        this.horaTermino = horaTermino;
    }

    public MedicoDTO getMedicoDTO() {
        return medicoDTO;
    }

    public void setMedicoDTO(MedicoDTO medicoDTO) {
        this.medicoDTO = medicoDTO;
    }

    
                
}
