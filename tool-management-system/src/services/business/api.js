import axios from 'axios'

export const baseUrl = 'https://localhost:7264'

export const endPoints = {
    aircrafts: 'Aircraft',
    toolboxes: 'Toolbox',
    users: 'User',
    tools: 'Tool',
    login: 'User/Authenticate'
}

export const apiService = endpoint => {

    let url = baseUrl + '/Api/' + endpoint + '/';
    return {
        fetchAll: () => axios.get(url),
        fetchById: id => axios.get(url + id),
        delete: id => axios.delete(url + id),
        put: (id, updatedForm) => axios.put(url + id, updatedForm),
        //postAircraft: newAircraftForm => axios.post(url, newAircraftForm),
        //postToolbox: newToolboxForm => axios.post(url, newToolboxForm),
        //postUser: newUser => axios.post(url, newUser),
        post: form => axios.post(url, form)
        }
}