/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package testwebservice;

import java.util.ArrayList;
import java.util.List;
import org.datacontract.schemas._2004._07.centromedico.ArrayOfEspecialidad;
import org.datacontract.schemas._2004._07.centromedico.CompositeType;
import org.datacontract.schemas._2004._07.centromedico.Especialidad;
import org.tempuri.GetEspecialidades;

/**
 *
 * @author Willywes
 */
public class TestWebService {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {

        Especialidad esp = new Especialidad();       
        

        ArrayOfEspecialidad lista = new ArrayOfEspecialidad();
        lista = getEspecialidades();
        
        ArrayList<Especialidad> list = (ArrayList<Especialidad>) lista.getEspecialidad();

//        System.out.println(list.get(1).getNombre().getValue());
        
        for(Especialidad item : list){
            
            int idtemp = item.getId();
            String nombre = item.getNombre().getValue();
            System.out.println("Id : " + idtemp + " Nombre Especialidad " + nombre);
        }


    }

    private static ArrayOfEspecialidad getEspecialidades() {
        org.tempuri.Servicio service = new org.tempuri.Servicio();
        org.tempuri.IServicio port = service.getBasicHttpBindingIServicio();
        return port.getEspecialidades();
    }

    private static Especialidad getEspecialidad(java.lang.Integer id) {
        org.tempuri.Servicio service = new org.tempuri.Servicio();
        org.tempuri.IServicio port = service.getBasicHttpBindingIServicio();
        return port.getEspecialidad(id);
    }

    private static String getData(java.lang.Integer value) {
        org.tempuri.Servicio service = new org.tempuri.Servicio();
        org.tempuri.IServicio port = service.getBasicHttpBindingIServicio();
        return port.getData(value);
    }

    private static CompositeType getDataUsingDataContract(org.datacontract.schemas._2004._07.centromedico.CompositeType composite) {
        org.tempuri.Servicio service = new org.tempuri.Servicio();
        org.tempuri.IServicio port = service.getBasicHttpBindingIServicio();
        return port.getDataUsingDataContract(composite);
    }

}
