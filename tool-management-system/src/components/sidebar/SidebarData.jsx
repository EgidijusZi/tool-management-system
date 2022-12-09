import { homePath, usersPath, toolsPath, aircraftsPath } from './constants/routes';
import HomeIcon from '@mui/icons-material/Home';
import GroupIcon from '@mui/icons-material/Group';
import BuildIcon from '@mui/icons-material/Build';
import LocalAirportIcon from '@mui/icons-material/LocalAirport';

export const sidebarData = [
    {
        title: 'Home',
        icon: <HomeIcon />,
        link: {homePath}
    },
    {
        title: 'Users',
        icon: <GroupIcon />,
        link: {usersPath}
    },
    {
        title: 'Tools',
        icon: <BuildIcon />,
        link: {toolsPath}
    },
    {
        title: 'Aircrafts',
        icon: <LocalAirportIcon />,
        link: {aircraftsPath}
    }
]