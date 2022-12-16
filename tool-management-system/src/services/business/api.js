import axios from 'axios'

export const baseUrl = 'https://localhost:7098'

export const endPoints = {
    aircrafts: 'Aircraft',
    toolboxes: 'Toolbox',
    users: 'User',
    tools: 'Tool'
}

export const createAPIEndpoint = endpoint => {

    let url = baseUrl + '/api/' + endpoint + '/';
    return {
        fetchAll: () => axios.get(url),
        fetchById: id => axios.get(url + id),
    }
}