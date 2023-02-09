import { createContext, useState, useContext } from "react";
import { apiService, endPoints } from "../services/business/api";
import { useNavigate } from "react-router-dom";
import { homePath } from "../constants/routes";

export const AuthContext = createContext({});

export const AuthProvider = ({ children }) => {

    const [user, setUser] = useState(null);
    const [errors, setErrors] = useState([])

    const navigate = useNavigate();

    const loginApiService = apiService(endPoints.login);
    const userApiService = apiService(endPoints.users);

    const getUser = async (id, token) => {
        const data = await userApiService.fetchById(id, token);
        setUser(data.data);
    }

    const login = async({ ...data }) => {
        try {
            const userData = await loginApiService.post(data);
            getUser(userData.data.id, userData.data.token);
            navigate(homePath)
        } catch (error) {
            if (error.response.status === 400) {
                setErrors(error.response.data.message);
            }
        }
    }

    return (
        <AuthContext.Provider value={{ user, login }}>
            { children }
        </AuthContext.Provider>
    );

}

export default function useAuthContext() {
    return useContext(AuthContext);
}