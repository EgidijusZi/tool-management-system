import {
  homePath,
  usersPath,
  toolsPath,
  aircraftsPath,
  toolboxesPath,
} from '../../constants/routes';
import HomeIcon from '@mui/icons-material/Home';
import GroupIcon from '@mui/icons-material/Group';
import BuildIcon from '@mui/icons-material/Build';
import LocalAirportIcon from '@mui/icons-material/LocalAirport';
import HomeRepairServiceIcon from '@mui/icons-material/HomeRepairService';

export const sidebarData = [
  {
    title: 'Home',
    icon: <HomeIcon />,
    link: { homePath },
    role: ['Manager', 'Storekeeper', 'Engineer'],
  },
  {
    title: 'Users',
    icon: <GroupIcon />,
    link: { usersPath },
    role: ['Manager', 'Storekeeper'],
  },
  {
    title: 'Tools',
    icon: <BuildIcon />,
    link: { toolsPath },
    role: ['Storekeeper'],
  },
  {
    title: 'Toolboxes',
    icon: <HomeRepairServiceIcon />,
    link: { toolboxesPath },
    role: ['Storekeeper'],
  },
  {
    title: 'Aircrafts',
    icon: <LocalAirportIcon />,
    link: { aircraftsPath },
    role: ['Manager', 'Storekeeper', 'Engineer'],
  },
];
