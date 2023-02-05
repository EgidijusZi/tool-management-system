import { createContext, useState, useContext } from "react";
import { apiService, endPoints } from "../services/business/api";
import { useNavigate } from "react-router-dom";

export const AuthContext = createContext({});

export const AuthProvider = ({ children }) => {

    const navigate = useNavigate();

    const [user, setUser] = useState(null);

    const loginApiService = apiService(endPoints.login);

    const login = async({ ...data }) => {
        try {
            await loginApiService.post(data)
            navigate('/')
        } catch {
            console.error("blablabla")
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