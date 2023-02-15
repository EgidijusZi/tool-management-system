import axios from 'axios';

export const baseUrl = 'https://localhost:7264';

export const endPoints = {
  aircrafts: 'Aircraft',
  toolboxes: 'Toolbox',
  users: 'User',
  tools: 'Tool',
  login: 'User/Authenticate',
  register: 'User/Register'
};

export const apiService = (endpoint) => {
  let url = baseUrl + '/Api/' + endpoint + '/';
  return {
    fetchAll: (token) =>
      axios.get(url, {
        headers: {
          Authorization: `Bearer ${token}`,
        },
      }),
    fetchById: (id, token) =>
      axios.get(url + id, {
        headers: {
          Authorization: `Bearer ${token}`,
        },
      }),
    delete: (id, token) =>
      axios.delete(url + id, {
        headers: {
          Authorization: `Bearer ${token}`,
        },
      }),
    put: (id, updatedForm, token) =>
      axios.put(url + id, updatedForm, {
        headers: {
          Authorization: `Bearer ${token}`,
        },
      }),
    //postAircraft: newAircraftForm => axios.post(url, newAircraftForm),
    //postToolbox: newToolboxForm => axios.post(url, newToolboxForm),
    //postUser: newUser => axios.post(url, newUser),
    post: (form, token) =>
      axios.post(url, form, {
        headers: {
          Authorization: `Bearer ${token}`,
        },
      }),
    postLogin: (form) => axios.post(url, form),
    postRegister: (form, token) =>
      axios.post(url, form, {
        headers: {
          Authorization: `Bearer ${token}`,
        },
      }),
  };
};
