import { createContext, useState, useContext, useEffect } from 'react';
import { apiService, endPoints } from '../services/business/api';
import { useNavigate } from 'react-router-dom';
import { loginPath, homePath } from '../constants/routes';
import { roleMap } from '../components/helpers/RoleMap';

export const AuthContext = createContext({});

export const AuthProvider = ({ children }) => {
  const [user, setUser] = useState(null);
  const [error, setError] = useState();

  const navigate = useNavigate();

  const loginApiService = apiService(endPoints.login);
  const userApiService = apiService(endPoints.users);

  const getUser = async (id, token) => {
    const data = await userApiService.fetchById(id, token);
    const userWithRoleAndToken = {
      ...data.data,
      token: token,
      role: roleMap[data.data.role],
    };
    setUser(userWithRoleAndToken);
  };

  const login = async ({ ...data }) => {
    try {
      const userData = await loginApiService.postLogin(data);
      localStorage.setItem('user', JSON.stringify(userData.data));
      getUser(userData.data.id, userData.data.token);
      navigate(homePath);
      setError();
    } catch (error) {
      if (error.response.status === 400) {
        setError(error.response.data.message);
      }
    }
  };

  const signout = async () => {
    localStorage.clear();
    setUser(null);
    navigate(loginPath);
  };

  useEffect(() => {
    const storedUser = localStorage.getItem('user');
    if (storedUser) {
      const userData = JSON.parse(storedUser);
      getUser(userData.id, userData.token);
      navigate(localStorage.getItem('currentPath'));
    }
  }, []);

  return (
    <AuthContext.Provider value={{ user, login, signout, error }}>
      {children}
    </AuthContext.Provider>
  );
};

export default function useAuthContext() {
  return useContext(AuthContext);
}
